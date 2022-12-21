function deleteBook(id) {
    var isConform = confirm("Are you sure you want to delete book?");
    if (isConform) {
        $.ajax({
            type: "POST",
            url: "/Book/DeleteBook",
            data: { "id": id },
            success: function (resp) {
                alert("Deleted Successfully!");
                location.href = "/";
            },
            error: function (resp) {
                alert(resp + "\nPlease Retry! Someting went wrong!");
                location.href = "/";
            }
        });
    }
}