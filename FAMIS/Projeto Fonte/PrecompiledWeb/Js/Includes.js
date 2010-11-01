/*** Temporary text filler function. Remove when deploying template. ***/
var gibberish=["This is just some filler text", "Welcome to Dynamic Drive CSS Library", "Demo content nothing to read here"]
function filltext(words){
for (var i=0; i<words; i++)
document.write(gibberish[Math.floor(Math.random()*3)]+" ")
}
function start(page) {
debugger;
//var winOpen = window.open('Security/MaintenanceUser.aspx', '', 'resizable=no,scrooling=no');
    var winOpen = window.open(page, '', 'resizable=no,scrooling=no');
    winOpen.moveTo(0, 0);
    winOpen.resizeTo(screen.availWidth, screen.availHeight);
    window.opener = window;
    window.close();
}
