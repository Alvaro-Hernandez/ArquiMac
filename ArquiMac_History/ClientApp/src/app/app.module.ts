import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { FuncionAdministradorService } from './Services/funcion-administrador.service';
import { ListarAdministradorComponent } from './Components/administrador/listar-administrador/listar-administrador.component';
import { EditarAdministradorComponent } from './Components/administrador/editar-administrador/editar-administrador.component';
import { CrearAdministradorComponent } from './Components/administrador/crear-administrador/crear-administrador.component';
import { ListarCursoComponent } from './Components/curso/listar-curso/listar-curso.component';
import { CrearCursoComponent } from './Components/curso/crear-curso/crear-curso.component';
import { EditarCursoComponent } from './Components/curso/editar-curso/editar-curso.component';
import { ListarDisenoComponent } from './Components/diseno/listar-diseno/listar-diseno.component';
import { ListarMaterialComponent } from './Components/material/listar-material/listar-material.component';
import { FuncionCursosService } from './Services/funcion-cursos.service';
import { FuncionDisenoArqService } from './Services/funcion-diseno-arq.service';
import { FuncionImagenArqService } from './Services/funcion-imagen-arq.service';
import { FuncionMaterialService } from './Services/funcion-material.service';
import { CrearMaterialComponent } from './Components/material/crear-material/crear-material.component';
import { EditarMaterialComponent } from './Components/material/editar-material/editar-material.component';
import { ListarDisenosarqComponent } from './Components/diseno/disenosarq/listar-disenosarq/listar-disenosarq.component';
import { ListarImagesarqComponent } from './Components/diseno/imagesarq/listar-imagesarq/listar-imagesarq.component';
import { CrearDisenoarqComponent } from './Components/diseno/disenosarq/crear-disenoarq/crear-disenoarq.component';
import { EditarDisenoarqComponent } from './Components/diseno/disenosarq/editar-disenoarq/editar-disenoarq.component';
import { EditarImgdisenoComponent } from './Components/diseno/imagesarq/editar-imgdiseno/editar-imgdiseno.component';
import { CrearImagedisenoarqComponent } from './Components/diseno/imagesarq/crear-imagedisenoarq/crear-imagedisenoarq.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    ListarAdministradorComponent,
    EditarAdministradorComponent,
    CrearAdministradorComponent,
    ListarCursoComponent,
    CrearCursoComponent,
    EditarCursoComponent,
    ListarDisenoComponent,
    ListarMaterialComponent,
    CrearMaterialComponent,
    EditarMaterialComponent,
    ListarDisenosarqComponent,
    ListarImagesarqComponent,
    CrearDisenoarqComponent,
    EditarDisenoarqComponent,
    EditarImgdisenoComponent,
    CrearImagedisenoarqComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot([
        { path: '', component: HomeComponent, pathMatch: 'full' },
        { path: 'ListarAdministrador', component: ListarAdministradorComponent },
        { path: 'EditarAdministrador/:id_Admin', component: EditarAdministradorComponent },
        { path: 'CrearAdministrador', component: CrearAdministradorComponent },
        { path: 'ListarCurso', component: ListarCursoComponent },
        { path: 'CrearCurso', component: CrearCursoComponent },
        { path: 'EditarCurso/:id_Curso', component: EditarCursoComponent },
        { path: 'ListarDiseno', component: ListarDisenoComponent },
        { path: 'ListarMaterial', component: ListarMaterialComponent },
        { path: 'CrearMaterial', component: CrearMaterialComponent },
        { path: 'EditarMaterial/:id_Material', component: EditarMaterialComponent },
        { path: 'ListarDisenosarq', component: ListarDisenosarqComponent },
        { path: 'ListarImagesarq', component: ListarImagesarqComponent },
        { path: 'CrearDisenoarq', component: CrearDisenoarqComponent },
        { path: 'EditarDisenoarq/:id_Diseno', component: EditarDisenoarqComponent },
        { path: 'EditarImagearq/:id_Imagen', component: EditarImgdisenoComponent },
        { path: 'CrearImagearq', component: CrearImagedisenoarqComponent }

    ])
    ],
    providers: [FuncionAdministradorService, FuncionCursosService, FuncionDisenoArqService, FuncionImagenArqService, FuncionMaterialService],
  bootstrap: [AppComponent]
})
export class AppModule { }
