import * as signalR from "@aspnet/signalr-client"

var connection = new signalR.HubConnection('/chat');

connection.on('broadcastMessage', function(name, message){

});

connection.start().then(
    function () {
        
    }
)