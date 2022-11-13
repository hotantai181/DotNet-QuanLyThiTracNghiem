using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class ThongKeDiemDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();

        public List<ThongKeDiemThi> getThongTinDiems_lop(string pMaMonHoc, string pMaLop, string pNienKhoa, string pHocKy)
        {
            return db.KetQuaBaiThis.Join(
                db.SinhVien_MonHocs,
                kqbt => kqbt.MaSVMH,
                sv_mh => sv_mh.MaSVMH,
                (kqbt, sv_mh) => new
                {
                    NienKhoa = kqbt.NienKhoa,
                    HocKy = kqbt.HocKy,
                    MaMh = sv_mh.MaMonHoc,
                    Diem = kqbt.Diem,
                    Msss = sv_mh.Mssv,
                    NgaySinh = db.SinhViens.Where(sv => sv.Mssv == sv_mh.Mssv).Single().NgaySinh,
                    MaLop = db.SinhViens.Where(sv => sv.Mssv == sv_mh.Mssv).Single().MaLop
                }).Where(ttKQ => ttKQ.MaMh == pMaMonHoc && ttKQ.NienKhoa == pNienKhoa && ttKQ.HocKy == pHocKy && ttKQ.MaLop == pMaLop).Select(tt => new ThongKeDiemThi
                {
                    HoTen = db.SinhViens.Where(sv => sv.Mssv == tt.Msss).Single().HoTen,
                    Mssv = tt.Msss,
                    Lop = tt.MaLop,
                    NgSinh = string.Format("{0:dd/MM/yyyy}", tt.NgaySinh),
                    Diem = tt.Diem
                }).ToList();
        }

        public List<ThongKeDiemThi> getThongTinDiems_phongThi(string pMaMonHoc, string pPhongThi, string pNienKhoa, string pHocKy, string pNgayThi)
        {
            return db.KetQuaBaiThis.Join(
                db.SinhVien_MonHocs,
                kqbt => kqbt.MaSVMH,
                sv_mh => sv_mh.MaSVMH,
                (kqbt, sv_mh) => new
                {
                    NienKhoa = kqbt.NienKhoa,
                    HocKy = kqbt.HocKy,
                    MaMh = sv_mh.MaMonHoc,
                    Diem = kqbt.Diem,
                    Msss = sv_mh.Mssv,
                    NgaySinh = db.SinhViens.Where(sv => sv.Mssv == sv_mh.Mssv).Single().NgaySinh,
                    MaLop = db.SinhViens.Where(sv => sv.Mssv == sv_mh.Mssv).Single().MaLop,
                    PhongThi = db.SinhVien_LichThis.Where(svlt => svlt.Mssv == sv_mh.Mssv)
                        .Select(svlt => svlt.LichThi)
                        .Where(lt => lt.NgayThi == DateTime.ParseExact(pNgayThi, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                        .Select(lt => lt.PhongThi).ToList(),
                }).Where(ttKQ => ttKQ.MaMh == pMaMonHoc && ttKQ.NienKhoa == pNienKhoa && ttKQ.HocKy == pHocKy && ttKQ.PhongThi.Contains(pPhongThi)).Select(tt => new ThongKeDiemThi
                {
                    HoTen = db.SinhViens.Where(sv => sv.Mssv == tt.Msss).Single().HoTen,
                    Mssv = tt.Msss,
                    Lop = tt.MaLop,
                    NgSinh = string.Format("{0:dd/MM/yyyy}", tt.NgaySinh),
                    Diem = tt.Diem
                }).ToList();
        }

        public List<string> getPhongThis(string pNgayThi)
        {
            return db.LichThis.Where(lt => lt.NgayThi == DateTime.ParseExact(pNgayThi, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                .Select(lt => lt.PhongThi).ToList();
        }
    }
}
