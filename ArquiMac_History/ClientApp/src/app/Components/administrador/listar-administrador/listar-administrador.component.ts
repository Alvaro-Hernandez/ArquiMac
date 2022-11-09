import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FuncionAdministradorService } from 'src/app/Services/funcion-administrador.service';
import { Lista_Admin } from '../../../Models/Lista_Administrador';

@Component({
  selector: 'app-listar-administrador',
  templateUrl: './listar-administrador.component.html',
  styleUrls: ['./listar-administrador.component.css']
})
export class ListarAdministradorComponent implements OnInit {

  constructor(private service: FuncionAdministradorService, private router: Router) { }

    administradores: Lista_Admin[];

    ngOnInit() {
        this.service.getAdmin()
            .subscribe(Data => this.administradores = Data);
    }

    EditarAdmin(id) {
        this.router.navigate(["EditarAdministrador", id]);
    }

    Eliminar(id) {
        this.service.deleteAdmin(id).subscribe(Data => {
            console.log(Data);
            alert("Datos Eliminados");
        });
        window.location.reload();
    }

    CrearAdministrador() {
        this.router.navigate(["CrearAdministrador"]);
    }
}
