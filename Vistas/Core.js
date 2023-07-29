const url = "http://localhost:5221/api/actores";

const getActores = async  ()=>{
    const config = {
        method :"GET",
        Headers:{
            'Content-Type': 'application/json'
        }
    }
    let respuesta = (await fetch(url,config)).json();
    return respuesta;
}
async function ObtenerActores(){
     await getActores()
    .then(res =>{
        console.log(res);
       res.forEach(actor =>{
        const {nombre} = actor;
        console.log(nombre); 
       })
    });  
} 
ObtenerActores();