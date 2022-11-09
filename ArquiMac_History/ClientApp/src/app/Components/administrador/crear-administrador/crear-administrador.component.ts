import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FormGroup, FormControl } from '@angular/forms';
import { FuncionAdministradorService } from 'src/app/Services/funcion-administrador.service';
import { Administrador } from '../../../Models/Administrador';

@Component({
  selector: 'app-crear-administrador',
  templateUrl: './crear-administrador.component.html',
  styleUrls: ['./crear-administrador.component.css']
})
export class CrearAdministradorComponent implements OnInit {

    constructor(private service: FuncionAdministradorService, private router: Router, private activedRouter: ActivatedRoute) { }

    dataAdministrador: Administrador;

    nuevoFormAdmin = new FormGroup({
        nombres: new FormControl(''),
        apellidos: new FormControl(''),
        usuario: new FormControl(''),
        contrasena: new FormControl(''),
        email: new FormControl(''),
    });

    ngOnInit() {

    }

    postAdmin(form: Administrador) {
        this.service.postAdmin(form).subscribe(Data => {
            alert("Datos Registrados");
        });
    }

    Salir() {
        this.router.navigate(["ListarAdministrador"]);
    }

}
