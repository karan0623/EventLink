// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification

/*Parts of this code ChatGPT was used in order to help with the functionality*/

$(document).ready(function () {
    // Attach an event listener to the form submission
    $("form").submit(function (event) {
        event.preventDefault(); // Prevent the form from submitting

        // Get the search input value
        var searchTerm = $(".form-control[type='search']").val().toLowerCase();

        // Perform the search logic
        $(".card").each(function () {
            var cardText = $(this).find('.card-text').text().toLowerCase();

            if (cardText.includes(searchTerm)) {
                $(this).show();
            } else {
                $(this).hide();
            }

            $(".card").each(function () {
                var cardText = $(this).find('.card-title').text().toLowerCase();

                if (cardText.includes(searchTerm)) {
                    $(this).show();
                } else {
                    $(this).hide();
                }
            });
        });
    });
});









