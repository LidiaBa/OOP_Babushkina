PGDMP                         {            Game    15.1    15.0 	    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            �           1262    24807    Game    DATABASE     z   CREATE DATABASE "Game" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Russian_Russia.1251';
    DROP DATABASE "Game";
                postgres    false            �            1259    33012    game    TABLE     .  CREATE TABLE public.game (
    id integer NOT NULL,
    datatime timestamp without time zone DEFAULT CURRENT_TIMESTAMP,
    level1try integer NOT NULL,
    true1 integer NOT NULL,
    level2try integer NOT NULL,
    true2 integer NOT NULL,
    level3try integer NOT NULL,
    true3 integer NOT NULL
);
    DROP TABLE public.game;
       public         heap    postgres    false            �            1259    33011    game_id_seq    SEQUENCE     �   ALTER TABLE public.game ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.game_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    215            �          0    33012    game 
   TABLE DATA           b   COPY public.game (id, datatime, level1try, true1, level2try, true2, level3try, true3) FROM stdin;
    public          postgres    false    215   	       �           0    0    game_id_seq    SEQUENCE SET     :   SELECT pg_catalog.setval('public.game_id_seq', 57, true);
          public          postgres    false    214            g           2606    33017    game game_pkey 
   CONSTRAINT     L   ALTER TABLE ONLY public.game
    ADD CONSTRAINT game_pkey PRIMARY KEY (id);
 8   ALTER TABLE ONLY public.game DROP CONSTRAINT game_pkey;
       public            postgres    false    215            �   �  x�m��m�0 �o��4���Z��:���#: _��K������c2N�A��~���I�D*�;��qw:�(;m񤻜RF��Z�Bc Ҋ� �O�\��PK�=nt�b�8Xn7��N�$s�9�s���ۧ���|%3]vH�D�X=����J}]'䕠��r���<���G�+5��ڊkDܭ5+�r���x�_�;��1(\���E�Q����b�O���U}�@�X��ڪ+�Ti����椲:�*	����!�@Q^}��N�#p�9����?KˇٓJ�U3����6�]�
i��/:��u�S+�����V����#�E�"T�jު�V&^a�������j򚞪i�����q��Ր���;�s0v�u�ʄ�ӫ�ՙ��ԸT�`$B�=��wMR]�b}8X�-aUo-����۽N��Vk��{hK�U>��ڍV_`�~ҡ�Ⱦ񚤪��<&�}��8��	9��ն\�ax�UC�U�5�X���T��� 9���7���*x�I���b� ��V�.��U����]����u�}�E��	<���f�n�LP���|�k�3�<ƺٸ۵�(��~��^�jc��V���z�FI���(���#4ݮvZ�VVc�1�-.w�k��&)���]��zS�g�n���.�ݭ� �zĻ��V���,�ݭ���o����˘p     