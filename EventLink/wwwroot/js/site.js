// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function getCategoryName(item) {
    if (item instanceof InstagramPostsEventsConcerts) {
        return 'Concerts';
    } else if (item instanceof InstagramPostsEventsSports) {
        return 'Sports';
    } else if (item instanceof InstagramPostsEventsRestaurants) {
        return 'Restaurants';
    } else {
        return 'All';
    }
}

function filterData(option) {
    var searchTerm = $("#searchInput").val().toLowerCase();

    $(".card").each(function () {
        var cardText = $(this).find('.card-text').text().toLowerCase();
        var category = getCategoryName(this);

        if ((option === 'All' || category === option) && cardText.includes(searchTerm)) {
            $(this).show();
        } else {
            $(this).hide();
        }
    });
}









