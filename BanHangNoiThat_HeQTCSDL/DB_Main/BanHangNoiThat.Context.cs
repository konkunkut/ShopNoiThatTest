﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanHangNoiThat_HeQTCSDL.DB_Main
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class BanHangNoiThatEntities : DbContext
    {
        public BanHangNoiThatEntities()
            : base("name=BanHangNoiThatEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DonHangBan> DonHangBans { get; set; }
        public virtual DbSet<DonHangNhap> DonHangNhaps { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<HangHoaBan> HangHoaBans { get; set; }
        public virtual DbSet<HangHoaNhap> HangHoaNhaps { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        [DbFunction("BanHangNoiThatEntities", "CTsanpham_ThongTinCTsp")]
        public virtual IQueryable<CTsanpham_ThongTinCTsp_Result> CTsanpham_ThongTinCTsp(string maSP)
        {
            var maSPParameter = maSP != null ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<CTsanpham_ThongTinCTsp_Result>("[BanHangNoiThatEntities].[CTsanpham_ThongTinCTsp](@MaSP)", maSPParameter);
        }
    
        [DbFunction("BanHangNoiThatEntities", "CTsanpham_Thongtinsp")]
        public virtual IQueryable<CTsanpham_Thongtinsp_Result> CTsanpham_Thongtinsp(string maDMSP)
        {
            var maDMSPParameter = maDMSP != null ?
                new ObjectParameter("MaDMSP", maDMSP) :
                new ObjectParameter("MaDMSP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<CTsanpham_Thongtinsp_Result>("[BanHangNoiThatEntities].[CTsanpham_Thongtinsp](@MaDMSP)", maDMSPParameter);
        }
    
        [DbFunction("BanHangNoiThatEntities", "DonHangofKH")]
        public virtual IQueryable<DonHangofKH_Result> DonHangofKH(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DonHangofKH_Result>("[BanHangNoiThatEntities].[DonHangofKH](@makh)", makhParameter);
        }
    
        [DbFunction("BanHangNoiThatEntities", "DS_DonHangBan")]
        public virtual IQueryable<DS_DonHangBan_Result> DS_DonHangBan(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DS_DonHangBan_Result>("[BanHangNoiThatEntities].[DS_DonHangBan](@makh)", makhParameter);
        }
    
        [DbFunction("BanHangNoiThatEntities", "DS_DonHangNhap")]
        public virtual IQueryable<DS_DonHangNhap_Result> DS_DonHangNhap()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DS_DonHangNhap_Result>("[BanHangNoiThatEntities].[DS_DonHangNhap]()");
        }
    
        [DbFunction("BanHangNoiThatEntities", "DSLoaisanpham")]
        public virtual IQueryable<DSLoaisanpham_Result> DSLoaisanpham()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DSLoaisanpham_Result>("[BanHangNoiThatEntities].[DSLoaisanpham]()");
        }
    
        [DbFunction("BanHangNoiThatEntities", "DSSP_theoLoaiSP")]
        public virtual IQueryable<DSSP_theoLoaiSP_Result> DSSP_theoLoaiSP(string maLoai)
        {
            var maLoaiParameter = maLoai != null ?
                new ObjectParameter("maLoai", maLoai) :
                new ObjectParameter("maLoai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DSSP_theoLoaiSP_Result>("[BanHangNoiThatEntities].[DSSP_theoLoaiSP](@maLoai)", maLoaiParameter);
        }
    
        [DbFunction("BanHangNoiThatEntities", "LoadTTSP_nhap")]
        public virtual IQueryable<LoadTTSP_nhap_Result> LoadTTSP_nhap(string maSP)
        {
            var maSPParameter = maSP != null ?
                new ObjectParameter("maSP", maSP) :
                new ObjectParameter("maSP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<LoadTTSP_nhap_Result>("[BanHangNoiThatEntities].[LoadTTSP_nhap](@maSP)", maSPParameter);
        }
    
        [DbFunction("BanHangNoiThatEntities", "Thongtinsanpham")]
        public virtual IQueryable<Thongtinsanpham_Result> Thongtinsanpham(string maloai)
        {
            var maloaiParameter = maloai != null ?
                new ObjectParameter("maloai", maloai) :
                new ObjectParameter("maloai", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Thongtinsanpham_Result>("[BanHangNoiThatEntities].[Thongtinsanpham](@maloai)", maloaiParameter);
        }
    
        [DbFunction("BanHangNoiThatEntities", "TTKH")]
        public virtual IQueryable<TTKH_Result> TTKH(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<TTKH_Result>("[BanHangNoiThatEntities].[TTKH](@makh)", makhParameter);
        }
    
        [DbFunction("BanHangNoiThatEntities", "ViewGioHang")]
        public virtual IQueryable<ViewGioHang_Result> ViewGioHang(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ViewGioHang_Result>("[BanHangNoiThatEntities].[ViewGioHang](@makh)", makhParameter);
        }
    
        [DbFunction("BanHangNoiThatEntities", "ViewKhachHang")]
        public virtual IQueryable<ViewKhachHang_Result> ViewKhachHang()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ViewKhachHang_Result>("[BanHangNoiThatEntities].[ViewKhachHang]()");
        }
    
        public virtual int CapNhat_Thongtinkhachhang(string maKH, string hoTen, string gioiTinh, string diaChi, string email, Nullable<int> sDT)
        {
            var maKHParameter = maKH != null ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(string));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            var gioiTinhParameter = gioiTinh != null ?
                new ObjectParameter("GioiTinh", gioiTinh) :
                new ObjectParameter("GioiTinh", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var sDTParameter = sDT.HasValue ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CapNhat_Thongtinkhachhang", maKHParameter, hoTenParameter, gioiTinhParameter, diaChiParameter, emailParameter, sDTParameter);
        }
    
        public virtual int CapNhat_TongTien(Nullable<int> tongTien, Nullable<int> donHB)
        {
            var tongTienParameter = tongTien.HasValue ?
                new ObjectParameter("TongTien", tongTien) :
                new ObjectParameter("TongTien", typeof(int));
    
            var donHBParameter = donHB.HasValue ?
                new ObjectParameter("DonHB", donHB) :
                new ObjectParameter("DonHB", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CapNhat_TongTien", tongTienParameter, donHBParameter);
        }
    
        public virtual int CapNhat_TTThanhToan(string maKH, string hoTen, string diaChi, string email, Nullable<int> sDT)
        {
            var maKHParameter = maKH != null ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(string));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var sDTParameter = sDT.HasValue ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CapNhat_TTThanhToan", maKHParameter, hoTenParameter, diaChiParameter, emailParameter, sDTParameter);
        }
    
        public virtual int Capnhatsoluong1sptronggio(Nullable<int> soluong, string maSP, string maKH)
        {
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("Soluong", soluong) :
                new ObjectParameter("Soluong", typeof(int));
    
            var maSPParameter = maSP != null ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(string));
    
            var maKHParameter = maKH != null ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Capnhatsoluong1sptronggio", soluongParameter, maSPParameter, maKHParameter);
        }
    
        public virtual ObjectResult<CapNhatTienSPTrenGio_Result> CapNhatTienSPTrenGio(string maSP, string maKH)
        {
            var maSPParameter = maSP != null ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(string));
    
            var maKHParameter = maKH != null ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CapNhatTienSPTrenGio_Result>("CapNhatTienSPTrenGio", maSPParameter, maKHParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> checkIdEmail(string makh, string email)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("checkIdEmail", makhParameter, emailParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> CheckLogin(string taikhoan, string matkhau)
        {
            var taikhoanParameter = taikhoan != null ?
                new ObjectParameter("taikhoan", taikhoan) :
                new ObjectParameter("taikhoan", typeof(string));
    
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("CheckLogin", taikhoanParameter, matkhauParameter);
        }
    
        public virtual int Delete_GioHang(string maKH)
        {
            var maKHParameter = maKH != null ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Delete_GioHang", maKHParameter);
        }
    
        public virtual int EditSP(string maSP, string maLoai, string tenSP, string kichCo, string mauSac, string xuatXu, string moTa, Nullable<int> soLuong, Nullable<double> giaVon, Nullable<double> giaBan)
        {
            var maSPParameter = maSP != null ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(string));
    
            var maLoaiParameter = maLoai != null ?
                new ObjectParameter("MaLoai", maLoai) :
                new ObjectParameter("MaLoai", typeof(string));
    
            var tenSPParameter = tenSP != null ?
                new ObjectParameter("TenSP", tenSP) :
                new ObjectParameter("TenSP", typeof(string));
    
            var kichCoParameter = kichCo != null ?
                new ObjectParameter("KichCo", kichCo) :
                new ObjectParameter("KichCo", typeof(string));
    
            var mauSacParameter = mauSac != null ?
                new ObjectParameter("MauSac", mauSac) :
                new ObjectParameter("MauSac", typeof(string));
    
            var xuatXuParameter = xuatXu != null ?
                new ObjectParameter("XuatXu", xuatXu) :
                new ObjectParameter("XuatXu", typeof(string));
    
            var moTaParameter = moTa != null ?
                new ObjectParameter("MoTa", moTa) :
                new ObjectParameter("MoTa", typeof(string));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            var giaVonParameter = giaVon.HasValue ?
                new ObjectParameter("GiaVon", giaVon) :
                new ObjectParameter("GiaVon", typeof(double));
    
            var giaBanParameter = giaBan.HasValue ?
                new ObjectParameter("GiaBan", giaBan) :
                new ObjectParameter("GiaBan", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EditSP", maSPParameter, maLoaiParameter, tenSPParameter, kichCoParameter, mauSacParameter, xuatXuParameter, moTaParameter, soLuongParameter, giaVonParameter, giaBanParameter);
        }
    
        public virtual int InsertNewID(string makh, string tenkh, string email, Nullable<int> tuoi, string gioitinh, string pass, string avatar, Nullable<int> sdt, string diachi)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var tenkhParameter = tenkh != null ?
                new ObjectParameter("tenkh", tenkh) :
                new ObjectParameter("tenkh", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var tuoiParameter = tuoi.HasValue ?
                new ObjectParameter("tuoi", tuoi) :
                new ObjectParameter("tuoi", typeof(int));
    
            var gioitinhParameter = gioitinh != null ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(string));
    
            var sdtParameter = sdt.HasValue ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(int));
    
            var diachiParameter = diachi != null ?
                new ObjectParameter("diachi", diachi) :
                new ObjectParameter("diachi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertNewID", makhParameter, tenkhParameter, emailParameter, tuoiParameter, gioitinhParameter, passParameter, avatarParameter, sdtParameter, diachiParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> KTmaSPtontai(string maSP)
        {
            var maSPParameter = maSP != null ?
                new ObjectParameter("maSP", maSP) :
                new ObjectParameter("maSP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("KTmaSPtontai", maSPParameter);
        }
    
        public virtual ObjectResult<string> LoadPic(string masp)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LoadPic", maspParameter);
        }
    
        public virtual ObjectResult<string> LoadPic_KH(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("LoadPic_KH", makhParameter);
        }
    
        public virtual ObjectResult<LocTheoDanhMucSP_Result> LocTheoDanhMucSP(string maLoaiSP)
        {
            var maLoaiSPParameter = maLoaiSP != null ?
                new ObjectParameter("MaLoaiSP", maLoaiSP) :
                new ObjectParameter("MaLoaiSP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LocTheoDanhMucSP_Result>("LocTheoDanhMucSP", maLoaiSPParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> ProcCheckID(string makh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("ProcCheckID", makhParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int TaoDonHangNhap(string maDHN, Nullable<System.DateTime> ngaynhap)
        {
            var maDHNParameter = maDHN != null ?
                new ObjectParameter("maDHN", maDHN) :
                new ObjectParameter("maDHN", typeof(string));
    
            var ngaynhapParameter = ngaynhap.HasValue ?
                new ObjectParameter("ngaynhap", ngaynhap) :
                new ObjectParameter("ngaynhap", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TaoDonHangNhap", maDHNParameter, ngaynhapParameter);
        }
    
        public virtual int ThemDonHangBan(string maKH, Nullable<System.DateTime> ngayHienTai, Nullable<int> tongTien)
        {
            var maKHParameter = maKH != null ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(string));
    
            var ngayHienTaiParameter = ngayHienTai.HasValue ?
                new ObjectParameter("NgayHienTai", ngayHienTai) :
                new ObjectParameter("NgayHienTai", typeof(System.DateTime));
    
            var tongTienParameter = tongTien.HasValue ?
                new ObjectParameter("TongTien", tongTien) :
                new ObjectParameter("TongTien", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemDonHangBan", maKHParameter, ngayHienTaiParameter, tongTienParameter);
        }
    
        public virtual int ThemHangHoaBan(string maDHB)
        {
            var maDHBParameter = maDHB != null ?
                new ObjectParameter("MaDHB", maDHB) :
                new ObjectParameter("MaDHB", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemHangHoaBan", maDHBParameter);
        }
    
        public virtual int ThemSPmoi(string maSP, string tenSP, string maLoai, string xuatxu, string kichco, Nullable<double> giavon, Nullable<double> giaban, string hinhanh, Nullable<int> soluong)
        {
            var maSPParameter = maSP != null ?
                new ObjectParameter("maSP", maSP) :
                new ObjectParameter("maSP", typeof(string));
    
            var tenSPParameter = tenSP != null ?
                new ObjectParameter("tenSP", tenSP) :
                new ObjectParameter("tenSP", typeof(string));
    
            var maLoaiParameter = maLoai != null ?
                new ObjectParameter("maLoai", maLoai) :
                new ObjectParameter("maLoai", typeof(string));
    
            var xuatxuParameter = xuatxu != null ?
                new ObjectParameter("xuatxu", xuatxu) :
                new ObjectParameter("xuatxu", typeof(string));
    
            var kichcoParameter = kichco != null ?
                new ObjectParameter("kichco", kichco) :
                new ObjectParameter("kichco", typeof(string));
    
            var giavonParameter = giavon.HasValue ?
                new ObjectParameter("giavon", giavon) :
                new ObjectParameter("giavon", typeof(double));
    
            var giabanParameter = giaban.HasValue ?
                new ObjectParameter("giaban", giaban) :
                new ObjectParameter("giaban", typeof(double));
    
            var hinhanhParameter = hinhanh != null ?
                new ObjectParameter("hinhanh", hinhanh) :
                new ObjectParameter("hinhanh", typeof(string));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemSPmoi", maSPParameter, tenSPParameter, maLoaiParameter, xuatxuParameter, kichcoParameter, giavonParameter, giabanParameter, hinhanhParameter, soluongParameter);
        }
    
        public virtual int ThemSpVaoGioHang(string maSP, string maKH, Nullable<int> soLuong)
        {
            var maSPParameter = maSP != null ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(string));
    
            var maKHParameter = maKH != null ?
                new ObjectParameter("MaKH", maKH) :
                new ObjectParameter("MaKH", typeof(string));
    
            var soLuongParameter = soLuong.HasValue ?
                new ObjectParameter("SoLuong", soLuong) :
                new ObjectParameter("SoLuong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemSpVaoGioHang", maSPParameter, maKHParameter, soLuongParameter);
        }
    
        public virtual int ThemvaoHangHoaNhap(string maSP, string maDHN, Nullable<int> soluong)
        {
            var maSPParameter = maSP != null ?
                new ObjectParameter("maSP", maSP) :
                new ObjectParameter("maSP", typeof(string));
    
            var maDHNParameter = maDHN != null ?
                new ObjectParameter("maDHN", maDHN) :
                new ObjectParameter("maDHN", typeof(string));
    
            var soluongParameter = soluong.HasValue ?
                new ObjectParameter("soluong", soluong) :
                new ObjectParameter("soluong", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemvaoHangHoaNhap", maSPParameter, maDHNParameter, soluongParameter);
        }
    
        public virtual int Tinh_TTDHN(string madhn)
        {
            var madhnParameter = madhn != null ?
                new ObjectParameter("madhn", madhn) :
                new ObjectParameter("madhn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Tinh_TTDHN", madhnParameter);
        }
    
        public virtual int UpdateNewPass(string matkhau, string id)
        {
            var matkhauParameter = matkhau != null ?
                new ObjectParameter("matkhau", matkhau) :
                new ObjectParameter("matkhau", typeof(string));
    
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateNewPass", matkhauParameter, idParameter);
        }
    
        public virtual int UploadPic(string masp, string hinhanh)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            var hinhanhParameter = hinhanh != null ?
                new ObjectParameter("hinhanh", hinhanh) :
                new ObjectParameter("hinhanh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UploadPic", maspParameter, hinhanhParameter);
        }
    
        public virtual int UploadPic_KH(string makh, string hinhanh)
        {
            var makhParameter = makh != null ?
                new ObjectParameter("makh", makh) :
                new ObjectParameter("makh", typeof(string));
    
            var hinhanhParameter = hinhanh != null ?
                new ObjectParameter("hinhanh", hinhanh) :
                new ObjectParameter("hinhanh", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UploadPic_KH", makhParameter, hinhanhParameter);
        }
    
        public virtual int XoaSanPham(string maSP)
        {
            var maSPParameter = maSP != null ?
                new ObjectParameter("MaSP", maSP) :
                new ObjectParameter("MaSP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("XoaSanPham", maSPParameter);
        }
    }
}
