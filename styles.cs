/* styles.css */
body {
    background-image: url('fondo.jpg');
    background-size: cover;
    background-repeat: no-repeat;
    background-position: center;
    font-family: 'Super Sedan', sans-serif;
    margin: 0;
    padding: 0;
    background-color: #000000;
    color: #fff;
    text-align: center;
}
#fondito {
    position: absolute; /* Establece la posición absoluta */
    top: 50px; /* Desplázala 50 píxeles desde la parte superior */
    left: 100px; /* Desplázala 100 píxeles desde la izquierda */
}
h1, h2, h3, p {
    font-family: 'Super Sedan', sans-serif;
}

.centrado {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    height: 100vh;
    color: #fff;
}

@font-face {
    font-family: 'Super Sedan';
    src: url('SuperSedan.ttf') format('truetype');
}

header {
    background-color: #333;
    padding: 20px;
}

nav ul {
    list-style: none;
    padding: 0;
}

nav li {
    display: inline;
    margin: 0 15px;
}

nav a {
    text-decoration: none;
}

main {
    max-width: 800px;
    margin: 20px auto;
    padding: 20px;
    background-color: #000;
}

footer {
    background-color: #333;
    padding: 10px;
}
