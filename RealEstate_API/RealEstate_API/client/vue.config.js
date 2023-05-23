const { defineConfig } = require('@vue/cli-service')
module.exports = defineConfig({
    transpileDependencies: true, 
    //devServer: {
    //    proxy: {
    //        '/api': {
    //            target: 'http://localhost:7046', // Replace with your ASP.NET Web API URL
    //            ws: true,
    //            changeOrigin: true
    //        }
    //    }
    //}
})
