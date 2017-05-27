<%@ page pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<link rel="stylesheet" href="public/css/common.css">
<title>Register Bank Branch</title>
</head>
<body>
	<div class="container">
		<div class="modal fade" id="insertBankBranchInfo" role="dialog">
			<div class="modal-dialog">
				<!-- Modal content-->
				<div class="modal-content popup">
					<div class="modal-header">
						<button type="button" class="close" data-dismiss="modal">&times;</button>
						<h4 class="modal-title">Bank Branch Information</h4>
					</div>
					<div class="modal-body">
						<form class="form-horizontal" action="#">
							<div class="form-group">
							      <label class="control-label col-sm-2" for="txtMaChiNhanh">Mã chi nhánh:</label>
							      <div class="col-sm-4">
							        	<input type="text" class="form-control" id="txtMaChiNhanh" placeholder="Mã chi nhánh" name="machinhanh">
							      </div>
							       <label class="control-label col-sm-2" for="txtTenChiNhanh">Tên chi nhánh:</label>
								   <div class="col-sm-4">
								   		<input type="text" class="form-control" id="txtTenChiNhanh" placeholder="Tên chi nhánh" name="tenchinhanh">
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
							      <label class="control-label col-sm-2" for="txtMaTruSo">Mã trụ sở:</label>
							      <div class="col-sm-4">
							        <input type="text" class="form-control" id="txtMaTruSo" placeholder="Mã trụ sở" name="matruso">
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