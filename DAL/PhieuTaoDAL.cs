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
                    MaMonHoc = pt.MaMonHoc,
                }).ToList();
        }
        public PhieuTaoDe get_tt_phieuTao(string pMaPhieu)
        {
            return db.PhieuTaoDes.Where(p => p.MaPhieuTaoDe.Equals(pMaPhieu)).FirstOrDefault();
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
        //public List<DSTaoDT> getDS_cauHoi(string pMaPhieuTao)
        //{
        //    return db.CauHois
        //        .Where(pt_c => pt_c.MaPhieuTaoDe.Equals(pMaPhieuTao))
        //        .Select(pt_c => new DSTaoDT
        //        {
        //            MaChuong = db.Chuongs.Where(c => c.MaChuong.Equals(pt_c.MaChuong)).Single().MaChuong,
        //            TenChuong = db.Chuongs.Where(c => c.MaChuong.Equals(pt_c.MaChuong)).Single().TenChuong,
        //            SoCauHoi = pt_c.SoLuongCau,
        //            Ma = pt_c.MaPTD_C
        //        }).OrderBy(pt_c => pt_c.MaChuong)
        //        .ToList();
        //}

        //public List<Chuong> getDs_cauHoi_conLai(string pMaMH, string pMaPhieuTao)
        //{
        //    return db.Chuongs
        //        .Where(c => c.MaMonHoc.Equals(pMaMH) &&
        //            !db.PhieuTaoDe_Chuongs.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPhieuTao))
        //                .Select(pt => pt.MaChuong).Contains(c.MaChuong))
        //        .ToList();
        //}

        //public bool remove_phieuTaoDe_chuong(int pMaPTD_C)
        //{
        //    try
        //    {
        //        // xóa data trong bảng mức độ
        //        var mucDo = db.MucDos.Where(md => md.MaPTD_C == pMaPTD_C)
        //            .ToList();

        //        db.MucDos.DeleteAllOnSubmit(mucDo);

        //        PhieuTaoDe_Chuong ptd_c = db.PhieuTaoDe_Chuongs
        //            .Where(pt => pt.MaPTD_C == pMaPTD_C).Single();

        //        db.PhieuTaoDe_Chuongs.DeleteOnSubmit(ptd_c);

        //        db.SubmitChanges();

        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
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
            string dt = db.DeThis.Where(pt => pt.MaPhieuTaoDe.Equals(ttpt)).ToString();
            var ttpt_chuong = db.ChiTietDeThis.Where(pt => pt.MaDe.Equals(dt)).ToList();

            ttpt_chuong.ForEach(pt_c =>
            {
                var a = db.CauHois.Where(md => md.MaCauHoi == pt_c.MaCauHoi).Sum(md => md.MaCauHoi);
                tongSoCau_chuong += a ;
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
                PhieuTaoDe ptd = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT)).FirstOrDefault();
                int sld = Int32.Parse(ptd.SoLuongDe.ToString());

                string ma = pMaPT.Substring(2);
               
                for (int i = 1; i <= sld; i++)
                {
                    db.DeThis.InsertOnSubmit(new DeThi
                    {
                        MaDe = string.Format("DT{0,00}" + pMaPT, int.Parse(ma) + i ),
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

        public int? getTGLamBai(string pMaPhieu)
        {
            PhieuTaoDe ttpt = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPhieu)).FirstOrDefault();
            int? tglambai = ttpt.ThoiGianLamBai;
            return tglambai;
        }

        public bool taoDeThiThuCong(string pMaPT)
        {
            try
            {
                List<DeThi> lstDt = db.DeThis.Where(dt => dt.MaPhieuTaoDe.Equals(pMaPT)).ToList();
                int? _soCauHoi = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT)).Select(pt => pt.SoCauHoi).Single();

                lstDt.ForEach(dt =>
                {
                    ChiTietDeThi ctdt = new ChiTietDeThi();
                    // thực hiện câu hỏi
                    db.ExecuteCommand("SET IDENTITY_INSERT ChiTietDeThi ON");

                    db.ChiTietDeThis.InsertOnSubmit(ctdt);

                    db.SubmitChanges();

                    db.ExecuteCommand("SET IDENTITY_INSERT ChiTietDeThi OFF");
                });
                return true;
            }
            catch(Exception e)
            {
                throw e;
                return false;
            }
        }
        public bool taoCTDeThiThuCong(string pMaPT,ChiTietDeThi chiTiet)
        {
            using (var dv = new QLThiTracNghiemDataContext())
            {
 
            try
            {
                    int? _soCauHoi = dv.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT)).Select(pt => pt.SoCauHoi).Single();
                    DeThi lstDt = dv.DeThis.Where(dt => dt.MaPhieuTaoDe.Equals(pMaPT)).FirstOrDefault();
                    int ctdt = dv.ChiTietDeThis.Where(dt => dt.MaDe.Equals(lstDt.MaDe)).Count();
                    if(ctdt <= _soCauHoi)
                    {
                        dv.ChiTietDeThis.InsertOnSubmit(chiTiet);
                        dv.SubmitChanges();
                    }
                    else
                    {
                        return false;
                    }
                return true;
            }
            catch(Exception e)
            {
                throw e;
                return false;
            }
            }
        }
        public bool ranDomCTDThiConLai(string pMaDe, string pMaPhieuTao)
        {
            try
            {
                //DeThi lstDt = db.DeThis.Where(dt => dt.MaDe.Equals(pMaDe)).FirstOrDefault();
                //List<DeThi> lstDTCL = db.DeThis.Where(dt => dt.MaDe.Equals(pMaDe)).ToList();
                //List<ChiTietDeThi> ctdt = db.ChiTietDeThis.Where(dt => dt.MaDe.Equals(lstDt.MaDe)).ToList();
                //int? _soCauHoi = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(lstDt.MaPhieuTaoDe)).Select(pt => pt.SoCauHoi).Single();
                //string _maMH = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pMaDe)).Select(pt => pt.MaMonHoc).Single();

                //for (int i = 1; i <= lstDTCL.Count; i++)  // Lap so de thi con lai
                //{
                //    ChiTietDeThi ctdtKT = new ChiTietDeThi();
                //    if (ctdtKT.MaDe != lstDTCL[i].MaDe)
                //    {   
                //        ctdt.ForEach(dt =>  // Lap List Chi Tiet De Thi Trong Da Tao 
                //        {
                //            List<CauHoi> cauHoi = db.CauHois.Where(ch => ch.MaMonHoc.Equals(_maMH)).ToList();

                //            for (int j = 0; j < _soCauHoi; j++)
                //        {


                //                Random r = new Random();  // Tao Moi Ham RanDom
                //                int index = r.Next(ctdt.Count);  // RanDom Trong DS Cau Hoi Trong Chi Tiet De Thi


                //                ctdtKT.MaDe = lstDTCL[i].MaDe;
                //                ctdtKT.MaCauHoi = dt.MaCauHoi;

                //                cauHoi.RemoveAt(index);

                //                    // thực hiện câu hỏi
                //                db.ExecuteCommand("SET IDENTITY_INSERT ChiTietDeThi ON");

                //                db.ChiTietDeThis.InsertOnSubmit(ctdtKT);

                //                db.SubmitChanges();

                //                db.ExecuteCommand("SET IDENTITY_INSERT ChiTietDeThi OFF");
                //            }
                //        });
                //    }
                //}
                try
                {
                    DeThi lstDtcl = db.DeThis.Where(dt => dt.MaDe.Equals(pMaDe)).FirstOrDefault();

                    List<DeThi> lstDt = db.DeThis.Where(dt => dt.MaPhieuTaoDe.Equals( pMaPhieuTao)).ToList();
                    int z = 0;
                    // tạo chi tiết cho từng đề thi
                    lstDt.ForEach(dt => // get n đề thi
                    {
                        // lấy câu hỏi từ chi tiet de th
                        List<ChiTietDeThi> ct = db.ChiTietDeThis.Where(g => g.MaDe.Equals(lstDtcl.MaDe)).ToList();
                       
                        string maDeThi = lstDt[z].MaDe;
                     
                        if (dt.MaDe != lstDtcl.MaDe)
                        {
                            for (int i = 0; i <  ct.Count; i++)
                            {
                                Random r = new Random(); 
                             
                                int index = r.Next(ct.Count);

                                ChiTietDeThi ctdt = new ChiTietDeThi();
                                ctdt.MaDe = maDeThi;
                                ctdt.MaCauHoi = ct[index].MaCauHoi;

                                ct.RemoveAt(index);

                                // thực hiện câu hỏi
                                db.ExecuteCommand("SET IDENTITY_INSERT ChiTietDeThi ON");
                                db.ChiTietDeThis.InsertOnSubmit(ctdt);

                                db.SubmitChanges();

                                db.ExecuteCommand("SET IDENTITY_INSERT ChiTietDeThi OFF");
                            }
                           
                        }
                        z++;
                    });
                    return true;
                }
                catch (Exception e)
                {
                        throw e;
                    return false;

                }
                return true;
            }
            catch(Exception e)
            {
                //throw e;
                return false;
            }
        }
        public bool taoCTDeThi(string pMaPT)
        {
            try
            {
                string _maMH = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT)).Select(pt => pt.MaMonHoc).Single();
                int? _soCauHoi = db.PhieuTaoDes.Where(pt => pt.MaPhieuTaoDe.Equals(pMaPT)).Select(pt => pt.SoCauHoi).Single();
                List<DeThi> lstDt = db.DeThis.Where(dt => dt.MaPhieuTaoDe.Equals(pMaPT)).ToList();
                // tạo chi tiết cho từng đề thi
                lstDt.ForEach(dt => // get n đề thi
                {

                    // lấy câu hỏi từ ngân hàng câu  hỏi
                    List<CauHoi> cauHoi = db.CauHois
                        .Where(ch => ch.MaMonHoc.Equals(_maMH)).ToList();

                    for (int i = 0; i < _soCauHoi; i++)
                    {
                        Random r = new Random();
                        int index = r.Next(cauHoi.Count);

                        ChiTietDeThi ctdt = new ChiTietDeThi();
                        ctdt.MaChiTietDeThi = 0 + i;
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