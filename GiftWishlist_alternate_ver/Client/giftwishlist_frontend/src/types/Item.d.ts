export interface IItem {
    "id": number,
    "name": string,
    "description": string,
    "price": number,
    "imageUrl": string,
    "imageThumbnailUrl": string
}

export interface IItemWishlist {
    id: number;
    item: IItem;
    quantityOnHand: number;
    idealQuantity: number;
}
