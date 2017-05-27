
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
	        },
	        success: function(response){
		    	alert(response.url);
		    	window.location.replace(response.url);
		    },
		    timeout: 10000,
	        error: function(xhr, status, err){ 
	            if(status=='timeout')
	            {   
	                alert('Request time has been out','');
	            }
	            console.log(status,err);
	        },
	        done : function(e) {
				console.log("DONE");
			}
	    });

	})
	
});