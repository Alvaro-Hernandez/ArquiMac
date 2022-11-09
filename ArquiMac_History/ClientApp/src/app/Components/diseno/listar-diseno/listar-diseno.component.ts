import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-listar-diseno',
  templateUrl: './listar-diseno.component.html',
  styleUrls: ['./listar-diseno.component.css']
})
export class ListarDisenoComponent implements OnInit {

    constructor(private router: Router) { }


    ngOnInit() {

    }

    goDisenoArq() {
        this.router.navigate(["ListarDisenosarq"]);
    }

    goImgArq() {
        this.router.navigate(["ListarImagesarq"]);
    }

}
