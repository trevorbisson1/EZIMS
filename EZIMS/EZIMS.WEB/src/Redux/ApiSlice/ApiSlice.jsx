import { createApi, fetchBaseQuery } from '@reduxjs/toolkit/query/react';

const ApiSlice = createApi({
    baseQuery: fetchBaseQuery({ baseUrl: 'https://localhost:7207/' }),
    endpoints: builder => ({

        // Item Controller
        getItems: builder.query({
            query: (itemID) => 'Item/GetItem?itemID=' + encodeURIComponent(itemID),
        })

        //Business Controller
    })
})

export const {
    useGetItemsQuery,

} = ApiSlice