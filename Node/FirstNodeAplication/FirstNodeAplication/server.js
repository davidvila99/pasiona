const http = require('http');
const url = require('url');
const fs = require('fs');
const port = 1337;

/*http.createServer(function (req, res) {
    console.log(req.url);
    if (req.url != '/') {
        fs.readFile('pages' + req.url + '.html', function (err, data) {
            if (!err) {
                res.writeHead(200, { 'Content-Type': 'text/html' });
                res.write(data);
                res.end();
            } else {
                res.writeHead(500, { 'Content-Type': 'text/html' });
                res.end();
            }
        });
    }
    else {
        res.writeHead(200, { 'Content-Type': 'text/html' });
        res.write("<h1>Index<h1>");
        res.end();
    }
}).listen(port);
*/
http.createServer(function (req, res) {

    let url = "";
    let type = "text/html";
    if (req.url.endsWith(".css")) {
        url = "." + req.url;
        console.log(url);
        type = "text/css";
    } else if (req.url.endsWith(".js")) {
        url = "." + req.url;
        type = "text/javascript";
    } else {
        url = "pages" + (req.url == "/" ? "/index" : req.url) + ".html";
    }
    console.log(url);
    fs.readFile(url, function (err, data) {
        if (!err) {
            res.writeHead(200, { "Content-Type": type });
            res.end(data);
        }
        else {
            res.writeHead(404, { "Content-Type": "text/html" });
            res.end("<h1>Not found</h1>");
        }
    });
}).listen(port);
