$(document).ready(function() {
	
	$("#btn-login").click(function() {
		var username = $('#login-username').val();
		var password = $('#login-password').val();
		$.ajax({
	        url: 'http://localhost:8080/BankManagement/bm/login',
	        type: 'POST',
	        dataType: 'json',
	        data : {
	        	username : username,
	        	password : password
	        }
	    })
	    .done(function (result) {
	    	window.location.href = "http://localhost:8080/BankManagement/bm/main";
	    })
	    .fail(function () {
	        alert('Fail');
	    })
	})
	
});