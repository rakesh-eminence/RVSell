export class BrandModel {

  GeneralInformation: string
  Faq: string;
  PoliciesAndProcedures: string
  parking: string
  AdditionalInformation: string


  constructor() {

  }

}
export class PropertyModel {
  BrandID: number;
  SkipRows: number;
  TakeRows: number;
  PropertyName: string
  DestinationTypeID: number;
  RoomMinimum: number;
  RoomMaximum: number;
  BathRoomMinimum: number;
  BathRoomMaximum: number;
  StateID: number;

}


export class PropertytabModel {
  PropertyName: string;
  PropertyID: number;
  propertyUnitdropList : Array<any>
}


export class DestinationModel {
  DestinationTypeID: number;
  DestinationTypeName: string

    }

export class StateModel {
  StateID: number;
  Name: string

}





