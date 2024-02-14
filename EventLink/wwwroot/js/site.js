// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification

/*Parts of this code ChatGPT was used in order to help with the functionality*/

$(document).ready(function () {
    // Attach an event listener to the form submission
    $("form").submit(function (event) {
        event.preventDefault(); // Prevent the form from submitting

        // Get the search input value
        var searchTerm = $(".form-control[type='search']").val().toLowerCase();

        // Reset the visibility of all cards before performing the search
        $(".card").show();

        // Perform the search logic for card-text and card-title
        $(".card").each(function () {
            var cardText = $(this).find('.card-text').text().toLowerCase();
            var cardTitle = $(this).find('.card-title').text().toLowerCase();

            if (!(cardText.includes(searchTerm) || cardTitle.includes(searchTerm))) {
                $(this).hide();
            }
        });
    });
});











