<%@ page pageEncoding="UTF-8"%>
<div id="areaStaff" class="col-xs-12 table-responsive">
	<table class="table table-bordered table-striped">
		<thead>
			<tr>
				<th class="">
					<button id="btnRegisterStaff" type="button" class="btn btn-info" data-toggle="modal" data-target="#insertStaffInfo">
						<span class='glyphicon glyphicon-plus' aria-hidden='true'></span>
					</button>
				</th>
				<th class="">Mã nhân viên</th>
				<th class="">Chi nhánh</th>
				<th class="">Địa chỉ</th>
				<th class="">Số điện thoại</th>
				<th class="">Trạng thái hoạt động</th>
				<th class="">Trụ sở</th>
				<th class="">
					<button id="btnUpdateStaff" type="button" class="btn btn-warning" data-toggle="modal" data-target="#insertStaffInfo">
						<span class='glyphicon glyphicon-transfer' aria-hidden='true'></span>
					</button>
				</th>
				<th class="">
					<button id="btnDeleteStaff" type="button" class="btn btn-danger">
						<span class='glyphicon glyphicon-remove' aria-hidden='true'></span>
					</button>
				</th>
			</tr>
		</thead>
		<tbody id="listStaff" class="table table-bordered table-striped"></tbody>
	</table>
</div>
<jsp:include page="registerStaff.jsp"></jsp:include>