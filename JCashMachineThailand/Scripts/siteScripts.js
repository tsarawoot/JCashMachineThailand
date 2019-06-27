
function googleMapJCMT() {
    // The location of Uluru
    var myLatlng = { lat: 13.7154312, lng: 100.5844659 };//J-Cash Machine (Thailand), 42Tower

    // The html element to show maps
    var mapCanvas = document.getElementById('mapArea');
    // Create option
    var mapOptions = {
        zoom: 17,
        center: myLatlng,
        //mapTypeId: 'satellite'
        mapTypeId: 'terrain'
    };
    // The map, centered at Uluru
    var map = new google.maps.Map(mapCanvas, mapOptions);
    //map.setTilt(45);//only some area
    // The marker, positioned at Uluru
    var marker = new google.maps.Marker({ position: myLatlng, map: map });
}


document.addEventListener('DOMContentLoaded', function () {
    if (document.querySelectorAll('#mapArea').length > 0) {
        if (document.querySelector('html').lang)
            lang = document.querySelector('html').lang;
        else
            lang = 'en';

        var key = 'AIzaSyC51i4Q9KbPcQhK-yoiAhesXK-TpmEeW6Q';// key by jcmthai.soft@gmail.com

        var js_file = document.createElement('script');
        js_file.type = 'text/javascript';
        js_file.src = 'https://maps.googleapis.com/maps/api/js?callback=googleMapJCMT&signed_in=true&language=' + lang ;
        document.getElementsByTagName('head')[0].appendChild(js_file);
    }
});




