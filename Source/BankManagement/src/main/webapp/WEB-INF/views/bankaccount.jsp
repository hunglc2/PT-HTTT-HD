<%@ page pageEncoding="UTF-8"%>
<div id="areaCustomer" class="col-xs-12 table-responsive">
	<table class="table table-bordered table-striped">
		<thead>
			<tr>
				<th class="">
					<button id="btnRegisterBankAccount" type="button" class="btn btn-info" data-toggle="modal" data-target="#insertBankAccountInfo">
						<span class='glyphicon glyphicon-plus' aria-hidden='true'></span>
					</button>
				</th>
				<th class="">Số tài khoản</th>
				<th class="">Chi nhánh đăng ký</th>
				<th class="">Ngày mở</th>
				<th class="">Ngày đóng</th>
				<th class="">Mã tiền tệ</th>
				<th class="">Số dư tối thiểu</th>
				<th class="">Loại tài khoản</th>
				<th class="">Mã khách hàng</th>
				<th class="">Trạng thái tài khoản</th>
				<th class="">
					<button id="btnUpdateBankAccount" type="button" class="btn btn-warning" data-toggle="modal" data-target="#insertBankAccountInfo">
						<span class='glyphicon glyphicon-transfer' aria-hidden='true'></span>
					</button>
				</th>
				<th class="">
					<button id="btnDeleteBankAccount" type="button" class="btn btn-danger">
						<span class='glyphicon glyphicon-remove' aria-hidden='true'></span>
					</button>
				</th>
			</tr>
		</thead>
		<tbody id="listCustomer" class="table table-bordered table-striped"></tbody>
	</table>
</div>
<jsp:include page="registerBankAccount.jsp"></jsp:include>