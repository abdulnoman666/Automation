"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
var class_transformer_1 = require("class-transformer");
var Result = /** @class */ (function () {
    function Result() {
    }
    __decorate([
        class_transformer_1.Expose()
    ], Result.prototype, "city", void 0);
    __decorate([
        class_transformer_1.Expose()
    ], Result.prototype, "year", void 0);
    __decorate([
        class_transformer_1.Expose()
    ], Result.prototype, "gold", void 0);
    __decorate([
        class_transformer_1.Expose()
    ], Result.prototype, "silver", void 0);
    __decorate([
        class_transformer_1.Expose()
    ], Result.prototype, "bronze", void 0);
    return Result;
}());
exports.Result = Result;
