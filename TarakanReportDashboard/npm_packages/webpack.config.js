﻿const path = require("path");

module.exports = {
    entry: "./node_modules/react-horizontal-datepicker/src/index.js",
    devtool: 'source-map',
    module: {
        rules: [
            {                
                test: /\.(js$|jsx)/,
                exclude: /node_modules/,
                use: {
                    loader: "babel-loader"
                }
            }
        ]
    },
    output: {
        path: path.resolve(__dirname, '../wwwroot/js'),
        filename: "bundle.js",
        library: "FluentUiComponents",
        libraryTarget: "window"
    }
};