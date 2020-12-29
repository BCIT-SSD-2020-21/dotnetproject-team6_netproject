import axios from 'axios';
import { IItemWishlist } from '@/types/Item';
/**
 * Wishlist Service.
 * Provides UI business logic associated with item inventory
 */

export class WishlistService {
    API_URL = process.env.VUE_APP_API_URL;

    public async getWishlist() : Promise<IItemWishlist[]> {
        console.log('getWishlist:', this.API_URL);
        let result = await axios.get(`${this.API_URL}/wishlist/`);
        return result.data;
    }

}
