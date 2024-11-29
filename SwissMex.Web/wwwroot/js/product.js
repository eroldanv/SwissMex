$(function () {   
    loadTable();
});

function loadTable() {

    dataTable = $('#myTable').DataTable({
        "ajax": { url: '/admin/product/getallproducts'},
        "columns": [
            { data: 'id', "width": "100%" }
        ]
    });

}