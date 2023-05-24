pageLoad();

function pageLoad() {
    
    var contador = 0;
    var titulo = document.getElementById("titulo");

    setInterval(() => {
        titulo.innerHTML = contador;
        contador++;
    }, 100);


    var subtitulo = document.getElementById("subtitulo");
    setTimeout(() => {
        subtitulo.innerHTML = "Página carregada com sucesso!";
    }, 5000);
    
    


}



function salvar() {
    alert('Bem Vindo!');
}