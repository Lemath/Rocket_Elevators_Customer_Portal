// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(() => {

  $("#hidden_field").children().children().prop("hidden", true);

  // $("#intervention_customer_id").change((event) => {

  //   $("#intervention_battery_id").prop("hidden", true).siblings().prop("hidden", true);
  //   $("#intervention_column_id").prop("hidden", true).siblings().prop("hidden", true);
  //   $("#intervention_elevator_id").prop("hidden", true).siblings().prop("hidden", true);

  //   let customer = $(event.currentTarget).val();
  //   if (customer == '') {
  //     $("#intervention_building_id").prop("hidden", true).siblings().prop("hidden", true);
  //   } else {
  //     $("#intervention_building_id").prop("hidden", false).siblings().prop("hidden", false);
  //   }

  //   $.ajax({
  //     method: "GET",
  //     url: "/buildings",
  //     dataType: "json",
  //     data: {customer: customer},
  //     error: function (xhr, status, error) {
  //       console.error('AJAX Error: ' + status + error);
  //     },
  //     success: (response) => {
  //       let buildings = response.buildings;
  //       $("#intervention_building_id").empty();
  //       $("#intervention_building_id").append('<option value="">Building Required</option>');
  //       for (let i = 0; i < buildings.length; i++) {
  //         $("#intervention_building_id").append(`<option value="${buildings[i].id}">${buildings[i].id}</option>`);
  //       }
  //     }
  //   });
  // });

  // $("#intervention_building_id").change((event) => {

  //   $("#intervention_column_id").prop("hidden", true).siblings().prop("hidden", true);
  //   $("#intervention_elevator_id").prop("hidden", true).siblings().prop("hidden", true);

  //   let building = $(event.currentTarget).val();
  //   if (building == '') {
  //     $("#intervention_battery_id").prop("hidden", true).siblings().prop("hidden", true);
  //   } else {
  //     $("#intervention_battery_id").prop("hidden", false).siblings().prop("hidden", false);
  //   }

  //   $.ajax({
  //     method: "GET",
  //     url: "/batteries",
  //     dataType: "json",
  //     data: {building: building},
  //     error: function (xhr, status, error) {
  //       console.error('AJAX Error: ' + status + error);
  //     },
  //     success: (response) => {
  //       let batteries = response.batteries;
  //       $("#intervention_battery_id").empty();
  //       $("#intervention_battery_id").append('<option value="">Battery Required</option>');
  //       for (let i = 0; i < batteries.length; i++) {
  //         $("#intervention_battery_id").append(`<option value="${batteries[i].id}">${batteries[i].id}</option>`);
  //       }
  //     }
  //   });
  // });

  // $("#intervention_battery_id").change((event) => {
  //   $("#intervention_elevator_id").prop("hidden", true).siblings().prop("hidden", true);
  //   let battery = $(event.currentTarget).val();
  //   if (battery == '') {
  //     $("#intervention_column_id").prop("hidden", true).siblings().prop("hidden", true);
  //   } else {
  //     $("#intervention_column_id").prop("hidden", false).siblings().prop("hidden", false);
  //   }
  //   $.ajax({
  //     method: "GET",
  //     url: "/columns",
  //     dataType: "json",
  //     data: {battery: battery},
  //     error: function (xhr, status, error) {
  //       console.error('AJAX Error: ' + status + error);
  //     },
  //     success: (response) => {
  //       let columns = response.columns;
  //       $("#intervention_column_id").empty();
  //       $("#intervention_column_id").append('<option value="">None</option>');
  //       for (let i = 0; i < columns.length; i++) {
  //         $("#intervention_column_id").append(`<option value="${columns[i].id}">${columns[i].id}</option>`);
  //       }
  //     }
  //   });
  // });
  
  // $("#intervention_column_id").change((event) => {
  //   let column = $(event.currentTarget).val();
  //   if (column == '') {
  //     $("#intervention_elevator_id").prop("hidden", true).siblings().prop("hidden", true);
  //   } else {
  //     $("#intervention_elevator_id").prop("hidden", false).siblings().prop("hidden", false);
  //   }
  //   $.ajax({
  //     method: "GET",
  //     url: "/elevators",
  //     dataType: "json",
  //     data: {column: column},
  //     error: function (xhr, status, error) {
  //       console.error('AJAX Error: ' + status + error);
  //     },
  //     success: (response) => {
  //       let elevators = response.elevators;
  //       $("#intervention_elevator_id").empty();
  //       $("#intervention_elevator_id").append('<option value="">None</option>');
  //       for (let i = 0; i < elevators.length; i++) {
  //         $("#intervention_elevator_id").append(`<option value="${elevators[i].id}">${elevators[i].id}</option>`);
  //       }
  //     }
  //   });
  // });
});