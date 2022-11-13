using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using DTO;
using System.Threading.Tasks;

using System.Globalization;

using DTO;
namespace DAL
{
    public class PhieuTaoDAL
    {
        QLThiTracNghiemDataContext db = new QLThiTracNghiemDataContext();

        public List<PhieuTaoDT> getPhieuTaos(string pMaGiaoVien)
        {
            return db.PhieuTaoDes.Where(pt => pt.MaGiaoVien.Equals(pMaGiaoVien)).OrderByDescending(pt => pt.NgayLap)
                .Select(pt => new PhieuTaoDT
                {
                    MaPhieu = pt.MaPhieuTaoDe,
                    NgayLap = string.Format("{0:dd/MM/yyyy}", pt.NgayLap),
                    TrangThai = pt.TrangThai,
                }).ToList();
        }
        public List<PhieuTaoDT> getPhieuTaos_NgayLap(string pNgayLap)
        {
            return db.PhieuTaoDes
                .Where(pt => pt.NgayLap == DateTime.ParseExact(pNgayLap, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                .Select(pt => new PhieuTaoDT
                {
                    MaPhieu = pt.MaPhieuTaoDe,
                    NgayLap = string.Format("{0:dd/MM/yyyy}", pt.NgayLap),
                    TrangThai = pt.TrangThai,
                }).ToList();
        }
        public PhieuTaoDe get_tt_phieuTao(string pMaPhieu)
        {
            return db.PhieuTaoDes.Where(p => p.MaPhieuTaoDe.Equals(pMaPhieu)).FirstOrDefault();
        }
        public List<PhieuTaoDe_Chuong> getPhieuTaoDe_Chuongs()
        {
            return db.PhieuTaoDe_Chuongs.ToList();
        }
        public List<MucDo> getMucDos()
        {
            var a = db.MucDos.ToList();
            return db.MucDos.ToList();
        }
        public List<MucDo> getMucDos(int pMaPT_c)
        {
            return db.MucDos.Where(md => md.MaPTD_C == pMaPT_c).ToList();
        }
        public bool add_phieuTao(PhieuTaoDe pt)
        {
            try
            {
                db.PhieuTaoDes.InsertOnSubmit(pt);

                db.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool add_phieuTao_chuong(PhieuTaoDe_Chuong pt)
        {
            try
            {
                db.ExecuteCommand("SET IDENTITY_INSERT PhieuTaoDe_chuong ON");
                db.PhieuTaoDe_Chuongs.InsertOnSubmit(pt);

                db.SubmitChanges();
                db.ExecuteCommand("SET IDENTITY_INSERT PhieuTaoDe_chuong OFF");

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool add_mucDo_chuong(MucDo pMucDo)
        {
            try
            {
                db.ExecuteCommand("SET IDENTITY_INSERT MucDo ON");

                db.MucDos.InsertOnSubmit(pMucDo);

                db.SubmitChanges();
                db.ExecuteCommand("SET IDENTITY_INSERT MucDo OFF");

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool change_phieuTao(PhieuTaoDe pPhieuTao)
        {
            try
            {
                PhieuTaoDe ttpt = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pPhieuTao.MaPhieuTaoDe)).Single();

                ttpt.SoCauHoi = pPhieuTao.SoCauHoi;
                ttpt.SoLuongDe = pPhieuTao.SoLuongDe;
                ttpt.ThoiGianLamBai = pPhieuTao.ThoiGianLamBai;
                ttpt.MaMonHoc = pPhieuTao.MaMonHoc;
                ttpt.TrangThai = pPhieuTao.TrangThai;

                db.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<PhieuTaoDe> getPhieuTaos()
        {
            return db.PhieuTaoDes.ToList();
        }
        public int getMaPT_chuong()
        {
            return db.PhieuTaoDe_Chuongs.OrderByDescending(pt_c => pt_c.MaPTD_C).FirstOrDefault().MaPTD_C;
        }
        public List<DSTaoDT> getDS_cauHoi(string pMaPhieuTao)
        {
            return db.PhieuTaoDe_Chuongs
                .Where(pt_c => pt_c.MaPhieuTaoDe.Equals(pMaPhieuTao))
                .Select(pt_c => new DSTaoDT
                {
                    MaChuong = db.Chuongs.Where(c => c.MaChuong.Equals(pt_c.MaChuong)).Single().MaChuong,
                    TenChuong = db.Chuongs.Where(c => c.MaChuong.Equals(pt_c.MaChuong)).Single().TenChuong,
                    SoCauHoi = pt_c.SoLuongCau,
                    Ma = pt_c.MaPTD_C
                }).OrderBy(pt_c => pt_c.MaChuong)
                .ToList();
        }

        public List<Chuong> getDs_cauHoi_conLai(string pMaMH, string pMaPhieuTao)
        {
            return db.Chuongs
                .Where(c => c.MaMonHoc.Equals(pMaMH) &&
                    !db.PhieuTaoDe_Chuongs.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPhieuTao))
                        .Select(pt => pt.MaChuong).Contains(c.MaChuong))
                .ToList();
        }

        public bool remove_phieuTaoDe_chuong(int pMaPTD_C)
        {
            try
            {
                // xóa data trong bảng mức độ
                var mucDo = db.MucDos.Where(md => md.MaPTD_C == pMaPTD_C)
                    .ToList();

                db.MucDos.DeleteAllOnSubmit(mucDo);

                PhieuTaoDe_Chuong ptd_c = db.PhieuTaoDe_Chuongs
                    .Where(pt => pt.MaPTD_C == pMaPTD_C).Single();

                db.PhieuTaoDe_Chuongs.DeleteOnSubmit(ptd_c);

                db.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool remove_phieuTaoDe(string pMaPTD)
        {
            try
            {
                PhieuTaoDe ptd = db.PhieuTaoDes
                    .Where(pt => pt.MaPhieuTaoDe == pMaPTD).Single();

                db.PhieuTaoDes.DeleteOnSubmit(ptd);

                db.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //----------------------------------------------------------

        public void kiemTraPhieuTao(string pMaPT)
        {
            PhieuTaoDe ttpt = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT)).FirstOrDefault();

            if (ttpt == null)
            {
                throw new Exception("Phiếu tạo đề không tồn tại. Vui lòng thử lại");
            }

            // kiểm tra tổng số câu các chương bằng với tổng số câu trên phiếu tạo
            int tongSoCau_chuong = 0;

            var ttpt_chuong = ttpt.PhieuTaoDe_Chuongs
                .Where(pt_c => pt_c.MaPhieuTaoDe.Equals(pMaPT)).ToList();

            ttpt_chuong.ForEach(pt_c =>
            {
                var a = db.MucDos.Where(md => md.MaPTD_C == pt_c.MaPTD_C).Sum(md => md.SoCau);
                tongSoCau_chuong += a ?? 0;
            });

            if (tongSoCau_chuong != ttpt.SoCauHoi)
            {
                throw new Exception("Phiếu tạo không hợp lệ. Vui lòng thử lại sau");
            }
        }

        public bool capNhatTrangThai(string pMaPT, string pMessage)
        {
            try
            {
                PhieuTaoDe ttpt = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT)).FirstOrDefault();

                ttpt.TrangThai = pMessage;

                db.SubmitChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool taoDeThi(string pMaPT)
        {
            try
            {
                int? _soLuong_deThi = db.PhieuTaoDes
                .Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT))
                .Select(pt => pt.SoLuongDe).Single();

                int idDe = int.Parse(db.DeThis
                    .OrderByDescending(dt => dt.MaDe)
                    .Select(dt => dt.MaDe)
                    .FirstOrDefault().Replace("DT", string.Empty));

                for (int i = 1; i <= (_soLuong_deThi ?? 0); i++)
                {
                    db.DeThis.InsertOnSubmit(new DeThi
                    {
                        MaDe = string.Format("DT{0:00}", idDe + i),
                        MaPhieuTaoDe = pMaPT
                    });

                    db.SubmitChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool taoCTDeThi(string pMaPT)
        {
            try
            {
                string _maMH = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT)).Select(pt => pt.MaMonHoc).Single();

                List<DeThi> lstDt = db.DeThis.Where(dt => dt.MaPhieuTaoDe.Equals(pMaPT)).ToList();
                List<PhieuTaoDe_Chuong> lstPT_c = db.PhieuTaoDe_Chuongs.Where(pt_c => pt_c.MaPhieuTaoDe.Equals(pMaPT)).ToList();
                // tạo chi tiết cho từng đề thi
                lstDt.ForEach(dt => // get n đề thi
                {
                    lstPT_c.ForEach(pt_c => // mỗi đề có n chương học
                    {
                        int? _maChuong = pt_c.MaChuong;

                        pt_c.MucDos.ToList().ForEach(md => // mỗi chương có 3 mức độ
                        {
                            int? soCauHoi = md.SoCau; // số câu hỏi ở từng mức độ

                            // lấy câu hỏi từ ngân hàng câu hỏi
                            List<NganHangCauHoi> cauHoi = db.NganHangCauHois
                                .Where(ch => ch.MaMonHoc.Equals(_maMH) && ch.MaChuong == _maChuong && ch.MucDo.Equals(md.MucDo1)).ToList();

                            for (int i = 0; i < (soCauHoi ?? 0); i++)
                            {
                                Random r = new Random();
                                int index = r.Next(cauHoi.Count);

                                ChiTietDeThi ctdt = new ChiTietDeThi();
                                ctdt.MaDe = dt.MaDe;
                                ctdt.MaCauHoi = cauHoi[index].MaCauHoi;

                                cauHoi.RemoveAt(index);

                                // thực hiện câu hỏi
                                db.ExecuteCommand("SET IDENTITY_INSERT ChiTietDeThi ON");

                                db.ChiTietDeThis.InsertOnSubmit(ctdt);

                                db.SubmitChanges();

                                db.ExecuteCommand("SET IDENTITY_INSERT ChiTietDeThi OFF");
                            }
                        });
                    });
                });

                return true;
            }
            catch (Exception e)
            {
                throw e;
                return false;
            }
        }
    }
}
