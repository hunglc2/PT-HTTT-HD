$(document).ready(function() {
	$("#insertCustomer").click(function() {
		//$("#dialog").dialog({modal: true, height: 590, width: 1005 });
		var w = window.open("", "registerCustomer", "width=600, height=400, scrollbars=yes");
		var $w = $(w.document.body);
		$w.html("<textarea></textarea>");
	});
});