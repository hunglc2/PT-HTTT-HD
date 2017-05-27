<%@ page pageEncoding="UTF-8"%>
<div id="areaCustomer" class="col-xs-12 table-responsive">
	<table class="table table-bordered table-striped">
		<thead>
			<tr>
				<th class="">
					<button id="btnRegisterBankBranch" type="button" class="btn btn-info" data-toggle="modal" data-target="#insertBankBranchInfo">
						<span class='glyphicon glyphicon-plus' aria-hidden='true'></span>
					</button>
				</th>
				<th class="">Mã chi nhánh</th>
				<th class="">Tên chi nhánh</th>
				<th class="">Địa chỉ</th>
				<th class="">Số điện thoại</th>
				<th class="">Mã trụ sở</th>
				<th class="">
					<button id="btnUpdateBankBranch" type="button" class="btn btn-warning" data-toggle="modal" data-target="#insertBankBranchInfo">
						<span class='glyphicon glyphicon-transfer' aria-hidden='true'></span>
					</button>
				</th>
				<th class="">
					<button id="btnDeleteBankBranch" type="button" class="btn btn-danger">
						<span class='glyphicon glyphicon-remove' aria-hidden='true'></span>
					</button>
				</th>
			</tr>
		</thead>
		<tbody id="listCustomer" class="table table-bordered table-striped"></tbody>
	</table>
</div>
<jsp:include page="registerBankBranch.jsp"></jsp:include>