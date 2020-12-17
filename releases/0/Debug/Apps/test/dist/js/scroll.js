$(document).ready(function(){
        $('#scroll a').click(function( e ){
            e.preventDefault();
            var el = $( this.getAttribute('href') );
            var offs = el.offset();
            $('html, body').stop().animate({ scrollTop: offs.top - 50},750);    
        });   
    });

function thanks(){
    location.href='http://download-codeplex.sec.s-msft.com/Download/Release?ProjectName=w8lock&DownloadId=773931&FileTime=130330950687570000&Build=20841';

}