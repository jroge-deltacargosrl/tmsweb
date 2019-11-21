//import Swal from "sweetalert2";

function generatePasswordForUser(i) {
    var itemTable = document.querySelectorAll("#tblUsuarios tr");
    var rowSelected = itemTable[i + 1];
    // tomar los datos del modelo
    let model = {
        id: rowSelected.cells[0].querySelector('span').innerHTML.trim(),
        email: rowSelected.cells[1].querySelector('span').innerHTML.trim(),
        tipo_c: Number(rowSelected.cells[2].children[0].getElementsByTagName('input')[0].checked),
        tipo_s: Number(rowSelected.cells[3].children[0].getElementsByTagName('input')[0].checked),
        tipo_e: Number(rowSelected.cells[4].children[0].getElementsByTagName('input')[0].checked),
        id_membership: 1, // Delta Cargo SRL
    };
    const url = 'https://localhost:44333/api/v1/user/'
    const options = {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(model)
    };
    fetch(url, options)
        .then(responseFormat => responseFormat.json())
        .then((data) => {
            const Toast = Swal.mixin({
                toast: true,
                position: 'top-end',
                showConfirmButton: false,
                timer: 3000
            })
            Toast.fire({
                type: 'success',
                title: 'Contraseña Enviada al usuario!!'
            })
        });
    return false;
}


