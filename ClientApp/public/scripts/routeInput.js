const { get } = require("http")

export default class routeInput {

    constructor(
        fromCity,
        toCity,
        company,
        recommendedDelivery,
        packageHeight,
        packageWidth,
        packageLength,
        packageWeight
    ) {

        fromCity = fromCity;
        toCity = toCity;
        company = company;
        recommendedDelivery = recommendedDelivery;
        packageHeight = packageHeight;
        packageWidth = packageWidth;
        packageLength = packageLength;
        packageWeight = packageWeight;

    }



}