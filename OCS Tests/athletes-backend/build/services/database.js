"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var sqlite3 = require("sqlite3");
var athelete_1 = require("../entities/athelete");
var game_1 = require("../entities/game");
var class_transformer_1 = require("class-transformer");
var result_1 = require("../entities/result");
var imageFile_1 = require("../entities/imageFile");
sqlite3.verbose();
var db_file = 'athletes.db';
var DatabaseAccessLayer = /** @class */ (function () {
    function DatabaseAccessLayer() {
        this.db = new sqlite3.Database(db_file, function (err) {
            if (err) {
                console.log(err.message);
                throw err;
            }
            else {
                console.log("Connected to SQLite database");
            }
        });
    }
    DatabaseAccessLayer.prototype.getAthlete = function (id) {
        var _this = this;
        var sql = "select * from Athlete where athlete_id = ?";
        var params = [id];
        return new Promise(function (resolve, reject) {
            return _this.db.all(sql, params, function (err, row) {
                if (err || row == null) {
                    var msg = "Unable to obtain athlete from db: " + err;
                    console.log(msg);
                    reject(msg);
                }
                else {
                    console.log(row);
                    var ath = class_transformer_1.plainToClass(athelete_1.Athlete, row, { excludeExtraneousValues: true });
                    resolve(ath[0]);
                }
            });
        });
    };
    DatabaseAccessLayer.prototype.getAthletes = function () {
        var _this = this;
        var sql = "select * from Athlete";
        return new Promise(function (resolve, reject) {
            _this.db.all(sql, function (err, rows) {
                if (err || rows == null) {
                    var msg = "Unable to obtain athletes";
                    console.log(msg);
                    reject(msg);
                }
                else {
                    var athletes = class_transformer_1.plainToClass(athelete_1.Athlete, rows, { excludeExtraneousValues: true });
                    resolve(athletes);
                }
            });
        });
    };
    DatabaseAccessLayer.prototype.getAthleteResults = function (id) {
        var _this = this;
        var sql = "\n            select g.city, g.year, ar.gold, ar.silver, ar.bronze  from AthleteResult ar\n            inner join Game g on ar.game_id = g.game_id\n            where ar.athlete_id = ?            \n        ";
        var params = [id];
        return new Promise(function (resolve, reject) {
            _this.db.all(sql, params, function (err, rows) {
                if (err || rows == null) {
                    var msg = "Unable to obtain results for athlete";
                    console.log(msg);
                    reject(msg);
                }
                else {
                    var results = class_transformer_1.plainToClass(result_1.Result, rows);
                    resolve(results);
                }
            });
        });
    };
    DatabaseAccessLayer.prototype.getAthletePhoto = function (id) {
        var _this = this;
        var sql = "select p.photo, p.mime_type from AthletePhoto p\n                   inner join Athlete a on a.photo_id = p.photo_id\n                   where a.athlete_id = ?";
        var params = [id];
        return new Promise(function (resolve, reject) {
            _this.db.get(sql, params, function (err, row) {
                if (err || row == null) {
                    var msg = "No image found for athlete with id: " + id;
                    console.log(msg);
                    reject(err);
                }
                else {
                    var img = new imageFile_1.ImageFile(row.mime_type, row.photo);
                    console.log(img);
                    resolve(img);
                }
            });
        });
    };
    DatabaseAccessLayer.prototype.getGames = function () {
        var _this = this;
        var sql = "select * from Game";
        return new Promise(function (resolve, reject) {
            _this.db.all(sql, function (err, rows) {
                if (err || rows == null) {
                    var msg = "Unable to obtain results for games";
                    console.log(msg);
                    reject(msg);
                }
                else {
                    var results = class_transformer_1.plainToClass(game_1.Game, rows);
                    resolve(results);
                }
            });
        });
    };
    DatabaseAccessLayer.prototype.getAthletesByGame = function (game_id) {
        var _this = this;
        var sql = "select a.* from Athlete a\n        inner join AthleteResult ar on a.athlete_id = ar.athlete_id\n        where ar.game_id = ?";
        var params = [game_id];
        return new Promise(function (resolve, reject) {
            _this.db.all(sql, params, function (err, rows) {
                if (err || rows == null) {
                    var msg = "Unable to obtain results for games";
                    console.log(msg);
                    reject(msg);
                }
                else {
                    var results = class_transformer_1.plainToClass(athelete_1.Athlete, rows);
                    resolve(results);
                }
            });
        });
    };
    return DatabaseAccessLayer;
}());
exports.DatabaseAccessLayer = DatabaseAccessLayer;
