"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var express = require("express");
var database_1 = require("./services/database");
require("reflect-metadata");
var app = express();
var cors = require('cors');
var dal = new database_1.DatabaseAccessLayer();
app.use(cors());
app.get("/athletes/:id", function (req, res) {
    dal.getAthlete(req.params.id)
        .then(function (data) {
        res.status(200).json(data);
    })
        .catch(function (error) { return res.status(404).json({ "error": error }); });
});
app.get("/athletes/:id/results", function (req, res) {
    dal.getAthleteResults(req.params.id)
        .then(function (data) {
        res.status(200).json(data);
    })
        .catch(function (error) { return res.status(404).json({ "error": error }); });
});
app.get("/athletes/:id/photo", function (req, res) {
    dal.getAthletePhoto(req.params.id)
        .then(function (data) {
        res.writeHead(200), {
            'Content-Type': data.mimeType,
            'Content-Lenght': data.content.length
        };
        res.end(data.content);
    })
        .catch(function (error) { return res.status(404).json({ "error": error }); });
});
app.get("/athletes", function (req, res) {
    dal.getAthletes()
        .then(function (data) {
        res.status(200).json(data);
    })
        .catch(function (error) { return res.status(404).json({ "error": error }); });
});
app.get("/games", function (req, res) {
    console.log("Received request for all games");
    dal.getGames()
        .then(function (data) {
        res.status(200).json(data);
    })
        .catch(function (error) { return res.status(500).json({ "error": error }); });
});
app.get("/games/:id/athletes", function (req, res) {
    console.log("Received request for all athletes for game " + req.params.id);
    dal.getAthletesByGame(req.params.id)
        .then(function (data) {
        res.status(200).json(data);
    })
        .catch(function (error) { return res.status(500).json({ "error": error }); });
});
app.listen(3000, function () {
    console.log('Started server on port 3000');
});
