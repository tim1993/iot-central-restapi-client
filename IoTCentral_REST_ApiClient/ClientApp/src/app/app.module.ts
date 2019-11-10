import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './modules/app/components/nav-menu/nav-menu.component';
import { HomeComponent } from './modules/app/components/home/home.component';
import { DeviceTemplatesComponent } from './modules/app/components/device-templates/device-templates.component';
import { RolesComponent } from './modules/app/components/roles/roles.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    DeviceTemplatesComponent,
    RolesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
        { path: '', component: HomeComponent, pathMatch: 'full' },
        { path: 'deviceTemplates', component: DeviceTemplatesComponent },
        { path: 'roles', component: RolesComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
