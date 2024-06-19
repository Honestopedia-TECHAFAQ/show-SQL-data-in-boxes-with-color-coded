function filterData() {
    var input = document.getElementById('search-box').value.toLowerCase();
    var boxes = document.getElementsByClassName('data-box');
    
    for (var i = 0; i < boxes.length; i++) {
        var title = boxes[i].getElementsByTagName('h3')[0].innerText.toLowerCase();
        if (title.includes(input)) {
            boxes[i].style.display = '';
        } else {
            boxes[i].style.display = 'none';
        }
    }
}
