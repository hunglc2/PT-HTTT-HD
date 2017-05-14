<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<div class="container">
		<div class="modal fade" id="insertCusInfo" role="dialog">
			<div class="modal-dialog">
				<!-- Modal content-->
				<div class="modal-content">
					<div class="modal-header">
						<button type="button" class="close" data-dismiss="modal">&times;</button>
						<h4 class="modal-title">Customer Information</h4>
					</div>
					<div class="modal-body">
						<form class="form-horizontal" action="#">
							<div class="row">
								<div class="form-group">
							      <label class="control-label col-sm-2" for="email">Email:</label>
							      <div class="col-sm-4">
							        <input type="email" class="form-control" id="email" placeholder="Enter email" name="email">
							      </div>
							    </div>
							    <div class="form-group">
							      <label class="control-label col-sm-2" for="email">Email:</label>
							      <div class="col-sm-4">
							        <input type="email" class="form-control" id="email" placeholder="Enter email" name="email">
							      </div>
							    </div>
							</div>
						</form>
					</div>
					<div class="modal-footer">
						<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
					</div>
				</div>
	
			</div>
		</div>
	</div>
</body>
</html>