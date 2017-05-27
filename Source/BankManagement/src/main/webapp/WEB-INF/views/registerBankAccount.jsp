<%@ page pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<link rel="stylesheet" href="public/css/common.css">
<title>Register Bank Account</title>
</head>
<body>
	<div class="container">
		<div class="modal fade" id="insertBankAccountInfo" role="dialog">
			<div class="modal-dialog">
				<!-- Modal content-->
				<div class="modal-content popup">
					<div class="modal-header">
						<button type="button" class="close" data-dismiss="modal">&times;</button>
						<h4 class="modal-title">Bank Account Information</h4>
					</div>
					<div class="modal-body">
						<form class="form-horizontal" action="#">
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtSoTaiKhoan">Số tài khoản:</label>
							      <div class="col-sm-4">
							        	<input type="text" class="form-control" id="txtSoTaiKhoan" placeholder="Số tài khoản" name="sotaikhoan">
							      </div>
							       <label class="control-label col-sm-2" for="txtChiNhanhDangKy">Chi nhánh đăng ký:</label>
								   <div class="col-sm-4">
								   		<input type="text" class="form-control" id="txtChiNhanhDangKy" placeholder="Chi nhánh đăng ký" name="chinhanhdangky">
								   </div>
							</div>
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtNgayMo">Ngày mở:</label>
							      <div class="col-sm-4">
							        <input type="date" class="form-control" id="txtNgayMo" placeholder="Ngày mở" name="ngaymo">
							      </div>
							      <label class="control-label col-sm-2" for="txtNgayDong">Ngày đóng:</label>
								   <div class="col-sm-4">
								   		<input type="date" class="form-control" id="txtNgayDong" placeholder="Ngày đóng" name="ngaydong">
								   </div>
							</div>
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtMaTienTe">Mã tiền tệ:</label>
							      <div class="col-sm-4">
							        <input type="text" class="form-control" id="txtMaTienTe" placeholder="Mã tiền tệ" name="matiente">
							      </div>
							      <label class="control-label col-sm-2" for="txtSoDuToiThieu">Số dư tối thiểu:</label>
								   <div class="col-sm-4">
								   		<input type="text" class="form-control" id="txtSoDuToiThieu" placeholder="Số dư tối thiểu" name="sodutoithieu">
								   </div>
							</div>
							<div class="form-group">
								  <label class="control-label col-sm-2" for="cmbLoaiTaiKhoan">Loại tài khoản:</label>
							      <div class="col-sm-4">
							        <select class="form-control" id="cmbLoaiTaiKhoan">
								        <option>1</option>
								        <option>2</option>
								        <option>3</option>
								        <option>4</option>
								    </select>
							      </div>
							      <label class="control-label col-sm-2" for="txtMaKhachHang">Mã khách hàng:</label>
							      <div class="col-sm-4">
							        <input type="text" class="form-control" id="txtMaKhachHang" placeholder="Mã khách hàng" name="makhachhang">
							      </div>
							</div>
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtTrangThaiTaiKhoan">Trạng thái tài khoản:</label>
							      <div class="col-sm-4">
							        <input type="text" class="form-control" id="txtTrangThaiTaiKhoan" placeholder="Trạng thái tài khoản" name="trangthaitaikhoan">
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