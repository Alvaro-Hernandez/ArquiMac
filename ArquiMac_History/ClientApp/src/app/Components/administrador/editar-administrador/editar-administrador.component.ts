import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { FuncionAdministradorService } from 'src/app/Services/funcion-administrador.service';
import { Administrador } from '../../../Models/Administrador';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-editar-administrador',
  templateUrl: './editar-administrador.component.html',
  styleUrls: ['./editar-administrador.component.css']
})
export class EditarAdministradorComponent implements OnInit {

    constructor(private service: FuncionAdministradorService, private router: Router, private activedRouter: ActivatedRoute) { }

    dataAdministrador: Administrador;

    editarFormAdmin = new FormGroup({
        id_Admin: new FormControl(''),
        nombres: new FormControl(''),
        apellidos: new FormControl(''),
        usuario: new FormControl(''),
        contrasena: new FormControl(''),
        email: new FormControl(''),
        error: new FormControl('')
    });

    ngOnInit() {
        let administradorId = this.activedRouter.snapshot.paramMap.get('id_Admin');
        this.service.getAdminId(administradorId).subscribe(Data => {
            this.dataAdministrador = Data;
            this.editarFormAdmin.patchValue({
                'id_Admin': this.dataAdministrador.id_Admin,
                'nombres': this.dataAdministrador.nombres,
                'apellidos': this.dataAdministrador.apellidos,
                'usuario': this.dataAdministrador.usuario,
                'contrasena': this.dataAdministrador.contrasena,
                'email': this.dataAdministrador.email
            });
        });
    }

    putAdmin(form: Administrador) {
        this.service.putAdmin(form).subscribe(Data => {
            console.log(Data);
            alert("Datos Editados");
        });

       this.router.navigate(["ListarAdministrador"]);
    }

    Salir() {
        this.router.navigate(["ListarAdministrador"]);
    }
}
