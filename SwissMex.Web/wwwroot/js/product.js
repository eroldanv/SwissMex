$(function () {   
    loadTable();
});

function loadTable() {

    dataTable = $('#myTable').DataTable({
        ajax: {
            url: '/admin/product/getallproducts'
        },
        columns: [
            { data: 'title', "width": "10%" },
            { data: 'description', "width": "40%" },
            { data: 'partNumber', "width": "10%" },
            { data: 'brand', "width": "10%" },
            { data: 'category.name', "width": "10%" },
            { data: 'listPrice', "width": "20%" },
            { data: 'id',
                render: function (data) {
                    return ` <div class="btn-group" role="group">
                            <a href="/admin/product/upsert?id=${data}" class="btn btn-primary btn-lg rounded-start-pill">
                                <i class="bi bi-pencil-square"></i>
                            </a>
                            <a asp-controller="Product" asp-route-id="@prod.Id" asp-action="Delete" class="btn btn-danger btn-lg  rounded-end-pill">
                                <i class="bi bi-trash"></i>
                            </a>
                        </div>`;
                }
            , "width": "20%" }

            
        ]
    });

}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!" ,
        icon: "warning", 
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    toastr.success(data.message);
                }
            });
        }
    });
}