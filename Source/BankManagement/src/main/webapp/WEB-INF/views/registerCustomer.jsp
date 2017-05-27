<%@ page pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<link rel="stylesheet" href="public/css/common.css">
<title>Insert title here</title>
</head>
<body>
	<div class="container">
		<div class="modal fade" id="insertCusInfo" role="dialog">
			<div class="modal-dialog">
				<!-- Modal content-->
				<div class="modal-content popup">
					<div class="modal-header">
						<button type="button" class="close" data-dismiss="modal">&times;</button>
						<h4 class="modal-title">Customer Information</h4>
					</div>
					<div class="modal-body">
						<form class="form-horizontal" action="#">
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtMaKhachHang">Mã khách hàng:</label>
							      <div class="col-sm-4">
							        	<input type="text" class="form-control" id="txtMaKhachHang" placeholder="Mã khách hàng" name="makhachhang">
							      </div>
							       <label class="control-label col-sm-2" for="txtChiNhanhDangKy">Chi nhánh đăng ký:</label>
								   <div class="col-sm-4">
								   		<input type="text" class="form-control" id="txtChiNhanhDangKy" placeholder="Chi nhánh đăng ký" name="chinhanhdangky">
								   </div>
							</div>
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtLoaiKhachHang">Loại khách hàng:</label>
							      <div class="col-sm-4">
							        <input type="text" class="form-control" id="txtLoaiKhachHang" placeholder="Loại khách hàng" name="loaikhachhang">
							      </div>
							      <label class="control-label col-sm-2" for="txtHoTen">Họ tên:</label>
								   <div class="col-sm-4">
								   		<input type="text" class="form-control" id="txtHoTen" placeholder="Họ tên" name="hoten">
								   </div>
							</div>
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtNgaySinh">Ngày sinh:</label>
							      <div class="col-sm-4">
							        <input type="date" class="form-control" id="txtNgaySinh" placeholder="Ngày sinh" name="ngaysinh">
							      </div>
							      <label class="control-label col-sm-2" for="txtGioiTinh">Giới tính:</label>
								   <div class="col-sm-4">
								   		<label class="radio-inline">
									      <input type="radio" name="gioitinh">Nam
									    </label>
									    <label class="radio-inline">
									      <input type="radio" name="gioitinh">Nữ
									    </label>
								   </div>
							</div>
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtDiaChi">Địa chỉ:</label>
							      <div class="col-sm-4">
							        <input type="text" class="form-control" id="txtDiaChi" placeholder="Địa chỉ" name="diachi">
							      </div>
							      <label class="control-label col-sm-2" for="txtSoDienThoai">Số điện thoại:</label>
								   <div class="col-sm-4">
								   		<input type="text" class="form-control" id="txtSoDienThoai" placeholder="Số điện thoại" name="sodienthoai">
								   </div>
							</div>
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtFax">Fax:</label>
							      <div class="col-sm-4">
							        <input type="text" class="form-control" id="txtFax" placeholder="Fax" name="fax">
							      </div>
							      <label class="control-label col-sm-2" for="txtEmail">Email:</label>
								   <div class="col-sm-4">
								   		<input type="email" class="form-control" id="txtEmail" placeholder="Email" name="email">
								   </div>
							</div>
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtCMND">CMND:</label>
							      <div class="col-sm-4">
							        <input type="text" class="form-control" id="txtCMND" placeholder="CMND" name="cmnd">
							      </div>
							      <label class="control-label col-sm-2" for="txtNoiCap">Nơi cấp:</label>
								   <div class="col-sm-4">
								   		<input type="text" class="form-control" id="txtNoiCap" placeholder="Nơi cấp" name="noicap">
								   </div>
							</div>
							<div class="form-group">
							   <label class="control-label col-sm-2" for="txtNgayCap">Ngày cấp:</label>
							   <div class="col-sm-4">
							   <input type="date" class="form-control" id="txtNgayCap" placeholder="Ngày cấp" name="ngaycap">
							   </div>
							</div>
						</form>
					</div>
					<div class="modal-footer">
						<button type="button" class="btn btn-info" data-dismiss="modal">Add</button>
						<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
					</div>
				</div>
	
			</div>
		</div>
	</div>
</body>
</html>