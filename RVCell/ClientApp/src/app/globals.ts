import { Injectable } from '@angular/core';

@Injectable()
export class Globals {
  searchText: string = '';
  brandIdGlobal: number = 0;
  RoomMinimum: number = 0;
  RoomMaximum: number = 0;
  BathRoomMinimum: number = 0;
  BathRoomMaximum: number = 0;
  DestinationTypeID: number = 0;
  StateID: number = 0;
  modelClose: number = 1;
  isMinmax: number = 0;
}
