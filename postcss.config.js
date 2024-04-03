module.exports = {
    plugins: [
        require('tailwindcss'),
        require('autoprefixer'),
        require('@fullhuman/postcss-purgecss')({
            content: [
                'D:/C# files/BulkyWeb/Views/**/*.cshtml',
                //'./Src/MyProject.Web/Pages/**/.html', // This is how you add other files
            ],
            defaultExtractor: content => content.match(/[A-Za-z0-9-_:/]+/g) || []
        })
  ]
}
