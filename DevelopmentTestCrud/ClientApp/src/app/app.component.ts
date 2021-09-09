import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';
  center = { lat: 24, lng: 12 };
  zoom = 15;
  display?: google.maps.LatLngLiteral;
}
