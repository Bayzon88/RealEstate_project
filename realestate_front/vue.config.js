const { defineConfig } = require("@vue/cli-service");
const webpack = require("webpack");
module.exports = defineConfig({
  transpileDependencies: true,
  chainWebpack: (config) => {
    config.plugin("html").tap((args) => {
      args[0].overlay = false;
      return args;
    });
  },
  configureWebpack: {
    devtool: "eval-source-map",
    stats: "none",
  },
  devServer: {
    proxy: {
      "/api": {
        target: "http://localhost:7046", // Replace with your ASP.NET Web API URL
        ws: true,
        changeOrigin: true,
      },
    },
  },
});
