<%@ page pageEncoding="UTF-8"%>
<div id="areaSavingBook" class="col-xs-12 table-responsive">
	<table class="table table-bordered table-striped">
		<thead>
			<tr>
				<th class="">
					<button id="btnRegisterSavingBook" type="button" class="btn btn-info" data-toggle="modal" data-target="#insertSavingBookInfo">
						<span class='glyphicon glyphicon-plus' aria-hidden='true'></span>
					</button>
				</th>
				<th class="">Mã sổ tiết kiệm</th>
				<th class="">Chi nhánh đăng ký</th>
				<th class="">Ngày mở</th>
				<th class="">Ngày đóng</th>
				<th class="">Mã khách hàng</th>
				<th class="">Số tài khoản</th>
				<th class="">Loại tiết kiệm</th>
				<th class="">Ngày đáo hạn</th>
				<th class="">
					<button id="btnUpdateSavingBook" type="button" class="btn btn-warning" data-toggle="modal" data-target="#insertSavingBookInfo">
						<span class='glyphicon glyphicon-transfer' aria-hidden='true'></span>
					</button>
				</th>
				<th class="">
					<button id="btnDeleteSavingBook" type="button" class="btn btn-danger">
						<span class='glyphicon glyphicon-remove' aria-hidden='true'></span>
					</button>
				</th>
			</tr>
		</thead>
		<tbody id="listSavingBook" class="table table-bordered table-striped"></tbody>
	</table>
</div>
<jsp:include page="registerSavingBook.jsp"></jsp:include>