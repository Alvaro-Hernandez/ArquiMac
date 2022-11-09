import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FuncionDisenoArqService } from 'src/app/Services/funcion-diseno-arq.service';
import { Diseno } from '../../../../Models/Diseno';

@Component({
  selector: 'app-listar-disenosarq',
  templateUrl: './listar-disenosarq.component.html',
  styleUrls: ['./listar-disenosarq.component.css']
})
export class ListarDisenosarqComponent implements OnInit {

    constructor(private service: FuncionDisenoArqService, private router: Router) { }

    disenos: Diseno[];

    ngOnInit() {
        this.service.getDiseno()
            .subscribe(Data => this.disenos = Data);
    }

    CrearDiseno() {
        this.router.navigate(["CrearDisenoarq"]);
    }

    Eliminar(id) {
        this.service.deleteDiseno(id).subscribe(Data => {
            console.log(Data);
            alert("Datos Eliminados");
        });
        window.location.reload();
    }

    Editar(id) {
        this.router.navigate(["EditarDisenoarq", id]);
    }
}
