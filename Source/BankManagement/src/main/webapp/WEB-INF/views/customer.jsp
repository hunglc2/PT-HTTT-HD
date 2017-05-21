<%@ page pageEncoding="UTF-8"%>
<div id="areaCustomer" class="col-xs-12 table-responsive">
	<table class="table table-bordered table-striped">
		<thead>
			<tr>
				<th class="">
					<button id="registerCustomer" type="button" class="btn btn-info" data-toggle="modal" data-target="#insertCusInfo">
						<span class='glyphicon glyphicon-plus' aria-hidden='true'></span>
					</button>
				</th>
				<th class="">Mã khách hàng</th>
				<th class="">Chi nhánh đăng ký</th>
				<th class="">Loại khách hàng</th>
				<th class="">Họ tên</th>
				<th class="">Ngày sinh</th>
				<th class="">Giới tính</th>
				<th class="">Địa chỉ</th>
				<th class="">Số điện thoại</th>
				<th class="">Fax</th>
				<th class="">Email</th>
				<th class="">CMND</th>
				<th class="">Nơi cấp</th>
				<th class="">Ngày cấp</th>
			</tr>
		</thead>
		<tbody id="listCustomer" class="table table-bordered table-striped">
		</tbody>
	</table>
</div>
<jsp:include page="registerCustomer.jsp"></jsp:include>