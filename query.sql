select p.title as 'Product title', c.title as 'Category title' from product as p
left join rel_category_product as rcp on rcp.productId = p.id
left join category as c on c.id = rcp.categoryId
order by p.title