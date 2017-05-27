<%@ page pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<link rel="stylesheet" href="public/css/common.css">
<title>Register Saving Book</title>
</head>
<body>
	<div class="container">
		<div class="modal fade" id="insertSavingBookInfo" role="dialog">
			<div class="modal-dialog">
				<!-- Modal content-->
				<div class="modal-content popup">
					<div class="modal-header">
						<button type="button" class="close" data-dismiss="modal">&times;</button>
						<h4 class="modal-title">Saving Book Information</h4>
					</div>
					<div class="modal-body">
						<form class="form-horizontal" action="#">
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtMaSoTietKiem">Mã sổ tiết kiệm:</label>
							      <div class="col-sm-4">
							        	<input type="text" class="form-control" id="txtMaSoTietKiem" placeholder="Mã sổ tiết kiệm" name="masotietkiem">
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
							      <label class="control-label col-sm-2" for="txtMaKhachHang">Mã khách hàng:</label>
							      <div class="col-sm-4">
							        <input type="text" class="form-control" id="txtMaKhachHang" placeholder="Mã khách hàng" name="makhachhang">
							      </div>
							      <label class="control-label col-sm-2" for="txtSoTaiKhoan">Số tài khoản:</label>
								  <div class="col-sm-4">
							        <input type="text" class="form-control" id="txtSoTaiKhoan" placeholder="Số tài khoản" name="sotaikhoan">
							      </div>
							</div>
							<div class="form-group">
							      <label class="control-label col-sm-2" for="cmbLoaiTietKiem">Loại tiết kiệm:</label>
							      <div class="col-sm-4">
							        <select class="form-control" id="cmbLoaiTietKiem">
								        <option>1</option>
								        <option>2</option>
								        <option>3</option>
								        <option>4</option>
								    </select>
							      </div>
							      <label class="control-label col-sm-2" for="txtNgayDaoHan">Ngày đáo hạn:</label>
								   <div class="col-sm-4">
								   		<input type="date" class="form-control" id="txtNgayDaoHan" placeholder="Ngày đáo hạn" name="ngaydaohan">
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