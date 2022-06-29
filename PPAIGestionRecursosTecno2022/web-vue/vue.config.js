//vue.config.js
module.exports = {
  publicPath: "/",
  devServer: {
    proxy: {
      '^/api*': {
        target: 'https://localhost:5000',
        ws: true,
        changeOrigin: true,
        secure: false,
      }
    }
  }
}