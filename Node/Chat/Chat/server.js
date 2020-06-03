let app = require('express')();
let http = require('http').createServer(app);
let io = require('socket.io')(http);
let palabrotas = ["puta", "gilipollas", "tonto", "caca", "culo"];

app.get('/', function (req, res) {
    res.sendFile('C:/Users/David/Desktop/Pasiona Stuff/Node/Chat/index.html');
});

io.on('connection', function (socket) {
    socket.on('chat message', function (msg) {
        console.log(msg.length);
        if (msg.length <= 140 && msg.length != 0) {
            msg = filter(msg);
            io.emit('chat message', msg);
        }
    });
});

function filter(msg) {
    palabrotas.forEach(function (word) {
        msg = msg.replace(new RegExp("\\b" + word + "\\b", "gi"), "*".repeat(word.length));
    });
    return msg;
}

http.listen(1337, function () {
    console.log('escuchando en *:1337');
});