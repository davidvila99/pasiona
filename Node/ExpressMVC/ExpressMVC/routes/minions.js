'use strict';
var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/minions', function (req, res) {
    res.render('minions', { title: 'Somos Minions', image: 'https://d3nt9em9l1urz8.cloudfront.net/media/catalog/product/cache/3/image/9df78eab33525d08d6e5fb8d27136e95/0/1/0128_190824_mp4otl_y_3.jpg' });
});

module.exports = router;
