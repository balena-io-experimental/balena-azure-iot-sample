
add_executable(buffer_unittests buffer_unittests.cpp main.c)


target_include_directories(buffer_unittests PUBLIC ${TEST_INCLUDES} ${COMMON_SRC})
target_link_libraries (buffer_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
