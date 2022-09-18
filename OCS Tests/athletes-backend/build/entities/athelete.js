"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var class_transformer_1 = require("class-transformer");
var Athlete = /** @class */ (function () {
    function Athlete(id, name) {
        this.athlete_id = id;
        this.name = name;
    }
    __decorate([
        class_transformer_1.Expose()
    ], Athlete.prototype, "athlete_id", void 0);
    __decorate([
        class_transformer_1.Expose()
    ], Athlete.prototype, "name", void 0);
    __decorate([
        class_transformer_1.Expose()
    ], Athlete.prototype, "surname", void 0);
    __decorate([
        class_transformer_1.Expose({ name: "date_of_birth" })
    ], Athlete.prototype, "dateOfBirth", void 0);
    __decorate([
        class_transformer_1.Expose()
    ], Athlete.prototype, "bio", void 0);
    __decorate([
        class_transformer_1.Expose()
    ], Athlete.prototype, "weight", void 0);
    __decorate([
        class_transformer_1.Expose()
    ], Athlete.prototype, "height", void 0);
    __decorate([
        class_transformer_1.Expose()
    ], Athlete.prototype, "photo_id", void 0);
    return Athlete;
}());
exports.Athlete = Athlete;
