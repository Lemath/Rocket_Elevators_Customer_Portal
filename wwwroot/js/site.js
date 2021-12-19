// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(() => 
{

	$("#hidden_field").children().children().prop("hidden", true);


	$("#building_id").change((event) => 
	{

		$("#column_id").parent().prop("hidden", true);
		$("#elevator_id").parent().prop("hidden", true);

		let building_id = $(event.currentTarget).val();
		if (building_id == '') 
		{
			$("#battery_id").parent().prop("hidden", true);
		} 
		else 
		{
			$("#battery_id").parent().prop("hidden", false);
		}
		console.log(building_id)
		$.ajax({
			type: "GET",
			url: 'Battery/BatteryOfBuilding',
			dataType: "json",
			data: {id: building_id},
			error: function (xhr, status, error) 
			{
				console.error('AJAX Error: ' + status + error);
			},
			success: (response) => 
			{
				console.log(response);
				
				$("#battery_id").empty();
				$("#battery_id").append('<option value="">Battery Required</option>');
				for (let i = 0; i < response.length; i++) 
				{
					$("#battery_id").append(`<option value="${response[i]}">${response[i]}</option>`);
				}
			}
		});
	});

	$("#battery_id").change((event) => 
	{
		$("#elevator_id").parent().prop("hidden", true)
		let battery_id = $(event.currentTarget).val();
		if (battery_id == '') 
		{
			$("#column_id").parent().prop("hidden", true)
		} 
		else 
		{
			$("#column_id").parent().prop("hidden", false)
		}
		$.ajax({
			method: "GET",
			url: "Column/ColumnOfBattery",
			dataType: "json",
			data: {id: battery_id},
			error: function (xhr, status, error) 
			{
				console.error('AJAX Error: ' + status + error);
			},
			success: (response) => {
				$("#column_id").empty();
				$("#column_id").append('<option value="">None</option>');
				for (let i = 0; i < response.length; i++) 
				{
					$("#column_id").append(`<option value="${response[i]}">${response[i]}</option>`);
				}
			}
		});
	});
	
	$("#column_id").change((event) => 
	{
		console.log("column change")	
		let column_id = $(event.currentTarget).val();
		if (column_id == '') 
		{
			$("#elevator_id").parent().prop("hidden", true);
		} 
		else 
		{
			$("#elevator_id").parent().prop("hidden", false);
		}
	  	$.ajax({
			method: "GET",
			url: "Elevator/ElevatorOfColumn",
			dataType: "json",
			data: {id: column_id},
			error: function (xhr, status, error) 
			{
				console.error('AJAX Error: ' + status + error);
			},
			success: (response) => {
				$("#elevator_id").empty();
				$("#elevator_id").append('<option value="">None</option>');
				for (let i = 0; i < response.length; i++) 
				{
					$("#elevator_id").append(`<option value="${response[i]}">${response[i]}</option>`);
				}
			}
	  	});
	});
});